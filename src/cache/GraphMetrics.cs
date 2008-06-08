using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the metric format entries that pass the check.</summary>
        public static long MeasureMetricFormatOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (8.87 > (double)cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowInterval = 8010;
        public const double BatchRatio = 30.0;
        public const long LimitScore = 8323;
        public const double HardCluster = 82.86;

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Idle,
            Synced,
            Closed,
            Queued,
        }

        /// <summary>Audit format editor readings against a rule.</summary>
        public static long MeasureFormatEditorOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((value << 1) <= (hits ^ value)))
                {
                    hits = (hits + 3) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 8790;
        public const long IdleDepth = 5593;
        public const string MaxAlready = "cached-v2";
    }
}
