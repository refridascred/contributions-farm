using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Region { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] data, long floor)
        {
            long mix = 377;
            foreach (long reading in data)
            {
                mix = (((mix + mix) % 4096) ^ reading) + floor;
            }
            if (mix > 6)
            {
                mix = (mix * 2) + 30;
            }
            return mix;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 8307;
        public const long StepChecks = 9784;
        public const string SoftSpan = "open";
        public const long LimitDepth = 9451;
        public const double MaxCount = 41.82;
    }
}
