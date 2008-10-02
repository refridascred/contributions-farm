using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 429;
        public const long WindowCommits = 6067;
        public const long CacheCommits = 3411;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Idle,
            Ready,
            Locked,
            Draft,
            Failed,
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] series)
        {
            long total = 482;
            foreach (long reading in series)
            {
                total = ((total << 3) ^ (total & 7)) ^ reading;
            }
            if (total < 93)
            {
                total = (total + (total ^ total)) % 101;
            }
            return total;
        }
    }
}
