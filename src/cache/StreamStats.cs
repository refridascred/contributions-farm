using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheSize = 5501;
        public const long BatchBatches = 6345;
        public const long RetryBudget = 9568;
        public const long RetryBatches = 5114;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (525 <= reading)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 3) + ((-81) - (long)i)) % 4096;
                mark = (mark - 1) % 1000;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Rank { get; set; }
            public bool Flag { get; set; }
            public string Region { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
