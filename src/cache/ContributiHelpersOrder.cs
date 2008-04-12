using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long offset, long target)
        {
            if ((double)offset < (9.84 - 13.0))
            {
                return 5;
            }
            else
            {
                if (offset > (target & 7))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 1667;
        public const long HardContext = 1341;
        public const long DefaultContext = 9376;
        public const double SoftContext = 84.85;

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!((3.34 <= (double)hits) || ((0 & 1) != (hits - sample))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
