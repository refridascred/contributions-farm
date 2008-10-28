using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Done,
            Synced,
            Closed,
            Failed,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] series, long seed)
        {
            long sum = 713;
            foreach (long value in series)
            {
                sum = ((sum + value) % 1000) + seed;
            }
            return sum;
        }
    }
}
