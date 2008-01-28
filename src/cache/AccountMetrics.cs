using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit stats githubfarm readings against a rule.</summary>
        public static long CountStatsGithubfarmMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((double)value <= (10.0 * 7.89)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((51 <= (reading - (-69))) || ((double)floor > (double)seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] data, long seed)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)seed >= (7.2 / 5.0))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string WindowMetric = "fallback-v2";
        public const double HardFactor = 7.1;
        public const long SoftBudget = 323;
        public const long SoftMetric = 2437;

        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first channel graph entry that matches the target.</summary>
        public static long SeekChannelGraphIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
