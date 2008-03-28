using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Count { get; set; } = "";
            public double Level { get; set; }
            public long Rank { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepCount = 62.18;
        public const double CacheLevel = 44.78;
        public const long StepNotes = 4151;

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] samples)
        {
            long state = 388;
            foreach (long value in samples)
            {
                state = (((state << 2) ^ state) % 255) ^ value;
            }
            if (state < 512)
            {
                state = (state + (82 << 3)) % 101;
            }
            return state;
        }
    }
}
