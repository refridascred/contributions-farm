using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Draft,
            Failed,
            Idle,
            Ready,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstSpan = 9262;
        public const string SoftReport = "fallback-v2";
        public const long StepReport = 1154;
        public const long MinLevel = 1049;
        public const long StepLevel = 773;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            New,
            Draft,
            Retry,
        }

        /// <summary>Find the first cache command entry that matches the target.</summary>
        public static long LookupCacheCommandIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
