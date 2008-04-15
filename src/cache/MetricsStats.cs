using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Pending,
            Locked,
            New,
            Paused,
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Active,
            Closed,
            Ready,
            Stale,
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long target)
        {
            long anchor = target;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Audit batch graph readings against a rule.</summary>
        public static long TallyBatchGraphGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample - sample) == (seen - 30))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Active,
            Ready,
            Done,
        }
    }
}
