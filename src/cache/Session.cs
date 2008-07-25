using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Stale,
            Failed,
            New,
            Queued,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string SoftBuffer = "local-v2";
        public const long IdleBuffer = 7623;
        public const string WindowLevel = "strict-edge";

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            New,
            Draft,
            Dropped,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count - target) >= (count << 1))
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }
    }
}
