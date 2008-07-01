using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Paused,
            Dropped,
            Done,
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double ratio, double bias)
        {
            double rate = (ratio / 9.0) / 6.0;
            if (rate > (bias - rate))
            {
                rate = rate + (8.2 + bias);
            }
            return rate - ratio;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Measure how many token support samples are out of range.</summary>
        public static long TallyTokenSupportOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry + entry) >= (hits << 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
