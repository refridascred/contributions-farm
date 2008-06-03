using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Rank { get; set; }
            public string Total { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double bias, double span)
        {
            double ratio = (double)((-649) >> 3);
            if (ratio >= bias)
            {
                ratio = ratio + span;
            }
            return ratio + (19.0 * 16.0);
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long bound)
        {
            long result = bound;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 4) + (result * 3)) % 101;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
