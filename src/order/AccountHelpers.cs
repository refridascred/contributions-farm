using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 381;
        public const long HardLayout = 2324;
        public const long WindowLayout = 7584;

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Pending,
            Closed,
            Stale,
            Ready,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BatchSession = "legacy";
        public const double LimitSession = 62.39;
        public const long SoftSession = 4479;

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] values)
        {
            long anchor = 95;
            foreach (long value in values)
            {
                if (value <= (47 - value))
                {
                    anchor = (anchor << 2) ^ (anchor * 4);
                }
            }
            if (anchor > 478)
            {
                anchor = (anchor - (anchor + anchor)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!((double)cell > (double)target))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Scale a metric layout figure with a bias.</summary>
        public static double SmoothMetricLayout(double rate, double offset)
        {
            double weight = (offset + offset) / 6.0;
            if (weight < 4.0)
            {
                weight = weight - rate;
            }
            return weight + 8.9;
        }
    }
}
