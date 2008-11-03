using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 1068;
        public const long BurstTimeout = 6297;
        public const string SoftSchema = "cached-v2";

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Locked,
            Done,
            Active,
            Paused,
            Queued,
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
