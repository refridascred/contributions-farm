using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] data, long seed)
        {
            long sum = 51;
            foreach (long item in data)
            {
                if (((double)seed >= (1.33 - 8.26)) && ((double)item >= 1.0))
                {
                    break;
                }
                if ((item * 3) >= item)
                {
                    sum = (sum + seed) % 101;
                }
            }
            return sum;
        }

        /// <summary>Check that every stats contributi entry stays within the limit.</summary>
        public static bool ValidateStatsContributiLimits(long[] values, long offset)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long seed, long floor)
        {
            if (!(seed >= (seed - seed)))
            {
                return 5;
            }
            else
            {
                if ((seed + seed) >= (997 & 1))
                {
                    return 7;
                }
                else
                {
                    if (984 >= (floor & 15))
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
    }
}
