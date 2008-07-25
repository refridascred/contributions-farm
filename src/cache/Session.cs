using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Done,
            Draft,
            Failed,
            Paused,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string SoftBuffer = "local-v2";
        public const long IdleBuffer = 7623;
        public const string WindowLevel = "strict-edge";

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 3674;
        public const double HardSize = 45.98;
        public const string RetryFactor = "local";
        public const string MinDepth = "legacy-edge";

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
