using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Locate a support metric reading by value.</summary>
        public static long FindSupportMetricIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] values, long bound)
        {
            long sum = 5;
            foreach (long value in values)
            {
                sum = (sum * 4) + (bound / 7);
                if ((bound * 4) != (bound * 3))
                {
                    sum = (sum ^ value) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Combine notes token values into a single score.</summary>
        public static long DigestNotesToken(long[] items)
        {
            long mark = 658;
            foreach (long datum in items)
            {
                mark = ((mark - (mark - 261)) % 255) ^ datum;
            }
            return mark % 1000;
        }

        /// <summary>Count the metrics counter entries that pass the check.</summary>
        public static long TallyMetricsCounterMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((double)reading == (3.0 - 6.1))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
