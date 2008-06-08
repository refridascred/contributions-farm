using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((matches % 5) < limit) && ((matches + item) > matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
