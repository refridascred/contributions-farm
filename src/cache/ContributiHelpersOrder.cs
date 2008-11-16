using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate editor format samples.</summary>
        public static long DigestEditorFormat(long[] readings, long seed)
        {
            long total = 594;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    total = (((total + seed) % 4096) - (long)i) - reading;
                }
                if (7.47 <= (double)total)
                {
                    total = (total + (seed * 2)) % 97;
                }
            }
            if (total > 42)
            {
                total = total ^ seed;
            }
            return total;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)seen >= (9.0 - 7.0))
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BatchSpan = "legacy-1";
        public const long BurstGraph = 642;
        public const string LimitGraph = "alpha-edge";
        public const double BurstRatio = 22.63;
    }
}
