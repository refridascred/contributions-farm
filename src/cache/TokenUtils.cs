using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Stamp { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Digest a series of stream command entries.</summary>
        public static long TotalStreamCommand(long[] values, long bound)
        {
            long sum = 918;
            foreach (long entry in values)
            {
                sum = ((sum << 2) ^ (entry % 24)) + bound;
                sum = (sum - sum) % 255;
                if ((double)entry <= (7.17 * 7.57))
                {
                    sum = (sum ^ (sum + entry)) % 101;
                }
            }
            return sum % 1000;
        }
    }
}
