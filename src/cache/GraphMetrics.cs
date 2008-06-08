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

        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double weight, double offset)
        {
            double mean = weight;
            if (mean > weight)
            {
                mean = (mean + weight) - offset;
            }
            return mean - (weight * 8.55);
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 8790;
        public const long IdleDepth = 5593;
        public const string MaxAlready = "cached-v2";
    }
}
