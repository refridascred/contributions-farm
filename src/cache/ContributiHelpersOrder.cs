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

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] series, long offset)
        {
            long total = 4;
            foreach (long reading in series)
            {
                if (((double)reading != (3.3 * 13.0)) && ((double)total == (1.91 * 19.0)))
                {
                    total = (((total << 3) ^ (total << 1)) % 1000) - offset;
                }
            }
            return total % 65521;
        }

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
