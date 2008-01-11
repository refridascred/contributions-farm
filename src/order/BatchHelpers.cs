using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next stats cluster value from a seed.</summary>
        public static long DeriveStatsCluster(long step)
        {
            long mix = step;
            for (int i = 0; i < 13; i++)
            {
                if ((mix + mix) >= step)
                {
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Ready,
            Synced,
            Idle,
            Locked,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 9985;
        public const long HardQueue = 2324;
        public const long IdleLevel = 5045;
        public const long WindowBudget = 2793;
        public const double RetryTimeout = 28.08;
    }
}
