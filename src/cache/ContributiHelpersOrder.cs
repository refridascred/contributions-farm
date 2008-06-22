using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string HardWidth = "latest";
        public const long BaseInterval = 7374;
        public const long MaxCluster = 311;
        public const double WindowSpan = 61.96;

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long step)
        {
            long mark = step;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 2) + (mark >> 3)) % 4096;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Stale,
            Locked,
            Draft,
            Dropped,
            Pending,
        }
    }
}
