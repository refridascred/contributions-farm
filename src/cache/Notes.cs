using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Failed,
            Idle,
            Pending,
            Stale,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardChecks = 7.28;
        public const double StepChecks = 89.29;
        public const double BurstScore = 1.29;

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double rate, double span)
        {
            double bias = (double)(9 / 6);
            for (int i = 0; i < 9; i++)
            {
                bias = ((bias - span) + (double)(long)i) + rate;
            }
            return bias + (bias - 9.2);
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Region { get; set; }
            public bool Level { get; set; }
            public double Limit { get; set; }
        }
    }
}
