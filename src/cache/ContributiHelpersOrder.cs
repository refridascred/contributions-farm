using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 2309;
        public const long IdleFactor = 9321;
        public const long IdleLevel = 3211;
        public const long SoftBatches = 6146;

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] series)
        {
            long sum = 824;
            foreach (long sample in series)
            {
                sum = (((sum * 3) + (sum & 255)) % 4096) + sample;
            }
            return sum % 4096;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Failed,
            Closed,
            New,
        }
    }
}
