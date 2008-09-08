using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!!((reading + reading) < (5 + 36)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
