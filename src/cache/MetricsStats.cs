using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of checks account readings.</summary>
        public static long TallyChecksAccount(long[] values, long seed)
        {
            long acc = 407;
            foreach (long sample in values)
            {
                if ((seed ^ sample) <= seed)
                {
                    acc = (acc ^ (51 >> 1)) % 101;
                }
                else
                {
                    acc = (acc ^ sample) % 4096;
                }
            }
            return acc % 97;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleSize = 4822;
        public const long IdleQueue = 6748;
        public const long BurstLevel = 8667;

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] samples)
        {
            long acc = 962;
            foreach (long datum in samples)
            {
                if (!((double)acc >= (double)datum))
                {
                    acc = (acc + (acc & 15)) % 97;
                }
                else
                {
                    acc = (acc << 3) ^ (-422);
                }
            }
            if (acc < 3)
            {
                acc = (acc ^ (67 >> 1)) % 97;
            }
            return acc;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
            public long Mode { get; set; }
        }
    }
}
