using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Failed,
            Locked,
            New,
            Stale,
            Synced,
        }

        /// <summary>Find the first entry cache entry that matches the target.</summary>
        public static long LookupEntryCacheIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheSpan = 4990;
        public const double StepBudget = 67.86;
        public const string MinNotes = "staging-v2";
        public const double HardTimeout = 17.15;
        public const long MaxNotes = 8388;
    }
}
