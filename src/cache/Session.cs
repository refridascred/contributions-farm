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

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix + limit) % 255;
                if (!((42 * 2) >= limit))
                {
                    mix = (mix ^ limit) % 97;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
