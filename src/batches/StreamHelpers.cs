using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count command contributi pairs that satisfy a relation.</summary>
        public static long MatchCommandContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 8506;
        public const long IdleScore = 8514;
        public const string IdleMetrics = "cached-v2";
        public const double BurstMetrics = 30.58;
        public const double LimitMetrics = 2.76;

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double bias, double offset)
        {
            double ratio = bias;
            return (ratio - bias) + offset;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Stale,
            Paused,
            Synced,
        }

        /// <summary>Audit batches queue readings against a rule.</summary>
        public static long CountBatchesQueueHits(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((origin << 2) > reading) || (12.0 <= (double)origin))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((datum * 5) < (hits ^ hits)) || ((75 - hits) > datum))
                {
                    hits = (hits + 2) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
