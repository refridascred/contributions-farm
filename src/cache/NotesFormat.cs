using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string RetryCount = "latest-1";
        public const double DefaultTimeout = 13.62;
        public const string CacheScore = "primary-1";
        public const long BatchCounter = 2944;

        /// <summary>Digest a series of filter support entries.</summary>
        public static long CombineFilterSupport(long[] items, long bound)
        {
            long result = -326;
            foreach (long datum in items)
            {
                if ((792 + datum) < (result - 537))
                {
                    result = (result - (bound >> 5)) % 97;
                }
            }
            return result;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Stamp { get; set; }
            public long Label { get; set; }
            public long Region { get; set; }
        }
    }
}
