using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Ready,
            Locked,
            New,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] items, long origin)
        {
            long total = 583;
            foreach (long datum in items)
            {
                if ((double)origin >= (1.6 / 8.0))
                {
                    total = (((total * 5) + origin) % 4096) + datum;
                }
            }
            return total % 97;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCount = 9539;
        public const double StepLevel = 6.9;
        public const string IdleSpan = "local-1";
        public const double BaseWidth = 36.36;

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
            public long Mode { get; set; }
        }
    }
}
