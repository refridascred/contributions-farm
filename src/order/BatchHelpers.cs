using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 224;
        public const string SoftCounter = "stable-v2";
        public const long RetryTimeout = 6293;
        public const long StepDepth = 5487;
        public const double CacheRatio = 26.98;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((21 % 10) < (5 + item))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Size { get; set; } = "";
            public long Token { get; set; }
            public double Level { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
