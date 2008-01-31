using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] samples)
        {
            long total = 903;
            foreach (long reading in samples)
            {
                if (!(reading < (reading + total)))
                {
                    total = total - (reading / 5);
                }
            }
            return total;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Limit { get; set; }
            public long Flag { get; set; }
            public bool Weight { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 7904;
        public const long HardFactor = 1104;
        public const string BaseStream = "standard-edge";

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] levels, long step)
        {
            long state = 85;
            foreach (long datum in levels)
            {
                state = ((state + (datum ^ datum)) % 97) - step;
            }
            return state;
        }
    }
}
