using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 879;
        public const string CacheFarm = "cached-1";
        public const long BatchDepth = 2041;

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitLevel = 2336;
        public const long BaseCount = 937;
        public const long RetryProfile = 9256;
        public const long StepLevel = 4095;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Idle,
            Paused,
            Queued,
        }

        /// <summary>Roll a counter account counter forward.</summary>
        public static long IterateCounterAccount(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            New,
            Failed,
            Ready,
            Closed,
        }
    }
}
