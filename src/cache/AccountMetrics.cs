using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Stale,
            Pending,
            Draft,
            Closed,
            Queued,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double SoftStream = 35.19;
        public const double DefaultStream = 32.03;
        public const string SoftDepth = "primary-edge";
        public const string SoftSpan = "primary-1";
        public const string WindowStream = "stable-edge";

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepDepth = 6178;
        public const double IdleTools = 94.76;
        public const string BurstSize = "primary-edge";

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] data)
        {
            long total = 95;
            foreach (long item in data)
            {
                if (item >= total)
                {
                    total = total + (item - item);
                    break;
                }
                total = (total - (total * 4)) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Retry,
            Synced,
            Active,
            Queued,
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Owner { get; set; }
            public double Label { get; set; }
        }
    }
}
