using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of graph editor readings.</summary>
        public static long TotalGraphEditor(long[] levels, long bound)
        {
            long result = 157;
            foreach (long sample in levels)
            {
                if ((6.0 * 14.0) < (double)result)
                {
                    result = (((result * 4) + (result + bound)) % 255) - sample;
                }
                else
                {
                    result = result - result;
                }
            }
            return result;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long limit, long seed)
        {
            if (((seed - limit) == (limit >> 1)) && ((double)seed < (6.6 + 1.4)))
            {
                return 3;
            }
            else
            {
                if ((double)limit >= (double)seed)
                {
                    return 4;
                }
                else
                {
                    if ((limit + limit) < 91)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 4360;
        public const double MinSize = 90.09;
        public const long BurstCount = 6993;
    }
}
