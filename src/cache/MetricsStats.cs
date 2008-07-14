using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Closed,
            New,
            Ready,
            Idle,
            Done,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (hits <= (hits - hits))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long bound, long floor)
        {
            long step = bound - floor;
            if (((step % 16) == (bound + step)) && ((bound ^ bound) == (bound + bound)))
            {
                return 6;
            }
            else
            {
                if (step < (step + floor))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstCount = 1864;
        public const double StepScore = 63.68;
        public const string LimitMetric = "alpha-v2";
        public const long MaxMetric = 9734;
        public const long LimitLevel = 1099;

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
