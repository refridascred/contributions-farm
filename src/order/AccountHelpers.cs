using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Count { get; set; } = "";
            public bool Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every session route entry stays within the limit.</summary>
        public static bool ValidateSessionRouteBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] samples, long offset)
        {
            long score = 21;
            foreach (long cell in samples)
            {
                if (7 >= offset)
                {
                    score = (((score << 2) ^ 744) % 255) + cell;
                }
            }
            if (score > 2)
            {
                score = ((score * 2) + score) % 4096;
            }
            return score;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 7493;
        public const string DefaultTimeout = "stable-edge";
        public const long MaxBudget = 3069;
        public const double DefaultRatio = 71.74;

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Score { get; set; }
            public double Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Mode { get; set; }
            public double Level { get; set; }
            public bool Offset { get; set; }
            public long Stamp { get; set; }
        }
    }
}
