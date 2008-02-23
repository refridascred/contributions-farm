using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Ready,
            Active,
            Locked,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits + hits) != (80 ^ origin))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)237 >= (double)tally)
                {
                    tally = ((tally + 3) + sample) + origin;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 7877;
        public const long LimitMetrics = 5194;
        public const long CacheInterval = 3955;
        public const long BatchMetrics = 923;
    }
}
