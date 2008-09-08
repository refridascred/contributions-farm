using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double HardStream = 36.98;
        public const long BurstStream = 3825;
        public const double HardWidth = 41.08;
        public const double MaxRatio = 11.81;

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] samples, long target)
        {
            long mix = 4;
            foreach (long sample in samples)
            {
                if ((5 ^ sample) >= ((-211) + target))
                {
                    mix = ((mix << 2) ^ (mix - target)) % 4096;
                }
                else
                {
                    mix = (mix + mix) % 101;
                }
            }
            return mix % 97;
        }

        /// <summary>Audit command entry readings against a rule.</summary>
        public static long CountCommandEntryMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)hits != (double)entry)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
