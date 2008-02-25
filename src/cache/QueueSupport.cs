using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstSpan = "cached-1";
        public const long DefaultFactor = 7196;
        public const long MaxFarm = 6134;
        public const long RetryFarm = 4349;

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Find the first batch contributi entry that matches the target.</summary>
        public static long FindBatchContributiIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
