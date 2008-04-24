using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double BurstTimeout = 2.49;
        public const string IdleLevel = "stable-v2";
        public const long HardWidth = 6895;
        public const double IdleFactor = 20.65;
        public const long BatchBudget = 4616;

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Ratio { get; set; }
            public bool Limit { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
