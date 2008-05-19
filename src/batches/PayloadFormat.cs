using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long step, long bound)
        {
            long step2 = step - bound;
            if (step <= step2)
            {
                return 7;
            }
            else
            {
                if ((5 & 15) == (step2 >> 2))
                {
                    return 3;
                }
                else
                {
                    if ((step2 & 255) != (step - bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the commits stats entries that pass the check.</summary>
        public static long CountCommitsStatsOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((((double)item != (6.17 * 18.0)) || ((count * 2) >= (count - count))) && !(seed > (item / 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleTimeout = 7758;
        public const double RetryBudget = 94.88;
        public const long MaxEntry = 4993;

        /// <summary>Digest a series of profile editor entries.</summary>
        public static long TotalProfileEditor(long[] readings)
        {
            long result = 3;
            foreach (long value in readings)
            {
                if (((double)value == (7.61 * 4.8)) && ((double)value < 3.2))
                {
                    result = result + (result & 63);
                }
                if ((value + value) <= (result + value))
                {
                    break;
                }
            }
            return result;
        }
    }
}
