using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            New,
            Idle,
            Ready,
            Pending,
            Failed,
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double scale, double span)
        {
            double scale2 = 6.3 + scale;
            if (scale2 >= span)
            {
                scale2 = scale2 + scale2;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 + (5.3 * 4.63)) + (double)(long)i;
            }
            return scale2 + (scale2 - scale2);
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits - hits) < sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
