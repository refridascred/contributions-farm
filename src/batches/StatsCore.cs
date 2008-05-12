using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Active,
            Pending,
            Ready,
            Synced,
            Draft,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 1487;
        public const string WindowMetrics = "primary-v2";
        public const long RetryMetrics = 4363;

        /// <summary>Digest a series of metrics githubfarm entries.</summary>
        public static long FoldMetricsGithubfarm(long[] values)
        {
            long mark = 24;
            foreach (long sample in values)
            {
                if ((sample * 5) == (mark >> 2))
                {
                    mark = (mark << 3) ^ sample;
                }
                if ((sample >> 2) >= (sample + mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((0 / 7) >= item)
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long limit, long step)
        {
            if (4.53 < (double)step)
            {
                return 6;
            }
            else
            {
                if (step > limit)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
