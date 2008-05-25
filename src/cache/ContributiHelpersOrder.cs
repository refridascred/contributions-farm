using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 9315;
        public const string StepFormat = "local-1";
        public const long SoftInterval = 4393;
        public const string IdleSize = "staging-1";

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 6487;
        public const long BaseCounter = 1276;
        public const long MaxTimeout = 6194;
        public const long BurstCounter = 4918;
        public const long DefaultCounter = 5929;

        /// <summary>Count the entry filter entries that pass the check.</summary>
        public static long CountEntryFilterHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (matches <= reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
