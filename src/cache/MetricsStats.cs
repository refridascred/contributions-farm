using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((2.0 - 2.0) > (3.0 * 6.1))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Rank cluster contributi input into a small class.</summary>
        public static long SortClusterContributi(long limit, long step)
        {
            if (step <= limit)
            {
                return 8;
            }
            else
            {
                if ((step + step) == (step / 7))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardFactor = 837;
        public const string BatchStream = "strict-1";
        public const double BurstRatio = 97.61;

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Dropped,
            Locked,
            Paused,
            Draft,
            Stale,
        }
    }
}
