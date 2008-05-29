using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long offset)
        {
            long state = offset;
            for (int i = 0; i < 12; i++)
            {
                state = (state + (offset * 5)) % 255;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum + sum) % 4096;
                sum = sum - (bound * 5);
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 3383;
        public const double RetryChecks = 36.94;
        public const double BurstFactor = 64.39;
        public const double CacheWidth = 44.79;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextOutliers(long[] items, long offset)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((reading * 2) >= (count << 2)) && ((count / 4) < count))
                {
                    count = (count + 3) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
