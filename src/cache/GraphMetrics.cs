using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two command queue measurements.</summary>
        public static double ProjectCommandQueue(double scale, double span)
        {
            double scale2 = (4.8 / 6.0) / 3.0;
            if (scale2 > scale)
            {
                scale2 = (scale2 + scale) - span;
            }
            else
            {
                scale2 = scale2 - (6.2 * 6.6);
            }
            return scale2 + scale2;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public double Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Failed,
            New,
            Active,
            Stale,
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Score { get; set; }
            public bool Stamp { get; set; }
            public double Mode { get; set; }
            public long Region { get; set; }
        }
    }
}
