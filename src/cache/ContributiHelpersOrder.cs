using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                if ((target * 4) < anchor)
                {
                    continue;
                }
                anchor = (anchor ^ ((long)i + 94)) % 65521;
                if (!((anchor - (long)i) <= (anchor - target)))
                {
                    anchor = ((anchor * 5) + (anchor >> 5)) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 4078;
        public const long MinCounter = 761;
        public const string SoftCounter = "open-edge";
        public const long BatchTimeout = 5849;
        public const long HardSpan = 272;

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
