using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Done,
            Synced,
            New,
            Failed,
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Locked,
            Pending,
            Idle,
            Ready,
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Total { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstSize = 7455;
        public const long LimitInterval = 7092;
        public const long BaseMetrics = 1908;

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Active,
            Dropped,
            Paused,
            Retry,
            Idle,
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
