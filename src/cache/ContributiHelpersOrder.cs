using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a editor stream counter forward.</summary>
        public static long SeriesEditorStream(long limit)
        {
            long result = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((result / 3) >= (long)i)
                {
                    break;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
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
