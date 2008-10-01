using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Pending,
            Queued,
            Stale,
            Retry,
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

        /// <summary>Define window limits and defaults.</summary>
        public const string MinRatio = "cached-1";
        public const long BaseWindow = 4807;
        public const double IdleWindow = 3.82;
        public const double CacheSpan = 74.32;
        public const long HardWindow = 25;

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
