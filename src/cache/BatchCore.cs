using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 5531;
        public const string IdleSupport = "stable-v2";
        public const long BaseSupport = 6223;
        public const double SoftSupport = 29.43;
        public const long BatchBudget = 1002;

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Stale,
            Ready,
            Paused,
            Done,
        }
    }
}
