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

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long limit)
        {
            long total = limit;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
