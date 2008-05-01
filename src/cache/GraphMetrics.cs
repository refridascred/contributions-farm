using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Active,
            Retry,
            New,
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Queued,
            Paused,
            Done,
            Stale,
            Closed,
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Level { get; set; }
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double ratio, double offset)
        {
            double bias = ratio;
            if (bias <= (bias * 8.7))
            {
                bias = bias + offset;
            }
            else
            {
                bias = bias - ratio;
            }
            return bias + (2.4 * 18.0);
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] data)
        {
            long carry = 17;
            foreach (long value in data)
            {
                if ((double)value >= (5.29 * 6.87))
                {
                    carry = (carry + (7 % 97)) % 255;
                }
            }
            return carry % 97;
        }
    }
}
