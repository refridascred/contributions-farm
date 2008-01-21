using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Pending,
            Locked,
            Paused,
            Draft,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] data, long seed)
        {
            long acc = 340;
            foreach (long value in data)
            {
                acc = ((acc + (11 - value)) % 4096) + seed;
            }
            return acc;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double HardTools = 67.74;
        public const long SoftRatio = 5268;
        public const long IdleTools = 8189;
    }
}
