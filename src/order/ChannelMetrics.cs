using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Queued,
            Stale,
            Locked,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] samples, long origin)
        {
            long acc = 60;
            foreach (long entry in samples)
            {
                if ((3.0 - 4.44) <= (double)entry)
                {
                    acc = ((acc << 2) ^ (origin - entry)) % 101;
                }
                else
                {
                    acc = ((acc * 3) + ((-1) * 5)) % 97;
                }
            }
            return acc % 1000;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] samples, long origin)
        {
            long total = 65;
            foreach (long value in samples)
            {
                total = ((total - (value & 63)) % 65521) - origin;
            }
            return total;
        }
    }
}
