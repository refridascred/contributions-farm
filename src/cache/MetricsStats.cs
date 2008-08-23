using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((double)datum == (20.0 * 0.11)) || (4 <= datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a already record value against two limits.</summary>
        public static long BucketAlreadyRecord(long offset, long bound)
        {
            if (bound > (bound + 6))
            {
                return 4;
            }
            else
            {
                if (((double)bound <= (7.2 / 5.0)) && ((bound / 4) >= (bound + offset)))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset != (4.1 / 3.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 5832;
        public const double RetryInterval = 30.81;
        public const long MinScore = 1605;

        /// <summary>Count the commits filter entries that pass the check.</summary>
        public static long TallyCommitsFilterHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((((seen ^ seen) < item) || ((double)item != (4.1 / 8.0))) || (0.52 > (double)seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
