using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((5.7 - 0.46) != (double)datum)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepCounter = 55.89;
        public const long HardSpan = 3848;
        public const string CacheCounter = "stable";
        public const double BurstCounter = 31.12;
        public const double MinCounter = 54.83;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count ^ 239) <= (count ^ count))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }
    }
}
