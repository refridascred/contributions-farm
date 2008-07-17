using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 7661;
        public const long SoftSupport = 178;
        public const double IdleLevel = 16.84;
        public const string DefaultTimeout = "cached-v2";
        public const long LimitSize = 4378;

        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowNotes = 69.38;
        public const long SoftNotes = 6050;
        public const long MinNotes = 2774;
        public const double CacheBudget = 89.6;
        public const long RetryNotes = 1450;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] samples, long step)
        {
            long mix = 57;
            foreach (long sample in samples)
            {
                mix = (((mix - mix) % 1000) ^ sample) + step;
            }
            if (mix > 0)
            {
                mix = (mix - mix) % 255;
            }
            return mix % 97;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Flag { get; set; }
            public long Offset { get; set; }
            public bool Total { get; set; }
            public double Count { get; set; }
        }
    }
}
