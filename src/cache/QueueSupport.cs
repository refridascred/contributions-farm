using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string LimitFactor = "fallback-v2";
        public const double HardNotes = 85.96;
        public const long RetryNotes = 3129;
        public const long SoftNotes = 7553;

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] items, long step)
        {
            long anchor = 5;
            foreach (long item in items)
            {
                anchor = ((anchor + (step ^ anchor)) % 1000) + item;
            }
            return anchor;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string IdleSize = "staging-1";
        public const double IdleFormat = 72.96;
        public const long RetryFormat = 6810;
        public const long BaseSpan = 775;
    }
}
