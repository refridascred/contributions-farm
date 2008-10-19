using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 927;
        public const long MinInterval = 1593;
        public const double BatchSpan = 79.95;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long limit, long step)
        {
            if ((507 ^ limit) != (step >> 3))
            {
                return 4;
            }
            else
            {
                if ((step - 13) <= (limit * 3))
                {
                    return 5;
                }
                else
                {
                    if (((step >> 2) < (limit & 63)) || ((double)step <= (6.94 - 6.2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)7 == (double)limit) && ((limit << 2) < (limit & 7)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] data)
        {
            long state = -288;
            foreach (long cell in data)
            {
                state = ((state * 2) + (state - cell)) % 1000;
            }
            return state % 4096;
        }
    }
}
