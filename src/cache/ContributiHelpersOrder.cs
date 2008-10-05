using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] data, long target)
        {
            long result = 9;
            foreach (long value in data)
            {
                if (value <= (value + 90))
                {
                    result = ((result + (888 & 255)) % 255) - target;
                }
            }
            return result % 4096;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchChecks = "local";
        public const long RetryChecks = 5637;
        public const long CacheCount = 555;

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Size { get; set; }
            public long Rank { get; set; }
        }
    }
}
