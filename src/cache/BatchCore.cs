using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 4020;
        public const double BurstRecord = 88.51;
        public const double BatchFactor = 14.32;

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] levels, long offset)
        {
            long state = 95;
            foreach (long value in levels)
            {
                state = ((state ^ (9 % 5)) % 97) + value;
            }
            if (state < 706)
            {
                state = state ^ (offset + 5);
            }
            return state;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long seed, long limit)
        {
            long diff = seed - limit;
            if ((seed * 3) >= (845 + 4))
            {
                return 1;
            }
            else
            {
                if (diff > (seed % 5))
                {
                    return 4;
                }
                else
                {
                    if (((6 + limit) <= (5 - (-604))) || (2.72 > (double)diff))
                    {
                        return 0;
                    }
                    else
                    {
                        if (diff <= limit)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
