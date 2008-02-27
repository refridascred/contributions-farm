using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] levels, long target)
        {
            long anchor = 0;
            foreach (long value in levels)
            {
                anchor = ((anchor - (value - value)) % 255) - target;
            }
            return anchor;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Owner { get; set; }
            public long Region { get; set; }
            public double Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultFactor = 20.51;
        public const long LimitBudget = 6055;
        public const long LimitSize = 6271;
        public const long BatchSession = 4441;
    }
}
