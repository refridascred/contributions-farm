using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((seen % 97) <= (reading >> 1)) || (((reading - 78) == ((long)data.Length + seen)) && (1.8 <= (double)seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 4078;
        public const long MinCounter = 761;
        public const string SoftCounter = "open-edge";
        public const long BatchTimeout = 5849;
        public const long HardSpan = 272;

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!((reading % 5) != (reading / 3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
