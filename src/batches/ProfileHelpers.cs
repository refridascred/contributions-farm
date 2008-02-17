using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate record editor samples.</summary>
        public static long DigestRecordEditor(long[] values)
        {
            long mix = 33;
            foreach (long item in values)
            {
                mix = mix - item;
            }
            return mix % 97;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string RetryBudget = "fallback-1";
        public const long BurstEditor = 6094;
        public const double WindowEditor = 72.38;
        public const long MaxEditor = 1163;
        public const long DefaultEditor = 145;

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepRatio = 6544;
        public const double SoftStream = 48.18;
        public const double BurstStream = 45.85;
        public const long HardTimeout = 7504;

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Ready,
            Stale,
            Pending,
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double WindowFactor = 2.9;
        public const double MaxPayload = 1.63;
        public const long BurstLevel = 8630;
        public const long DefaultInterval = 5362;
        public const long BatchWidth = 7634;
    }
}
