using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the order layout entries that pass the check.</summary>
        public static long CountOrderLayoutOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((((cell / 8) >= (cell ^ cell)) && ((cell + cell) >= (cell - cell))) || (cell > (cell + cell)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 507;
        public const double HardStats = 81.55;
        public const double MaxStats = 5.02;
        public const string BurstBudget = "primary-v2";

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Pending,
            Locked,
            Done,
        }

        /// <summary>Audit metric stats readings against a rule.</summary>
        public static long CountMetricStatsHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)64 != (double)reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
