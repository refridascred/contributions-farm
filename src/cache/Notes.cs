using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)hits <= (double)value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] readings, long floor)
        {
            long total = 902;
            foreach (long reading in readings)
            {
                total = (total * 4) + (floor - floor);
                if (total <= reading)
                {
                    total = total + (total % 5);
                }
                if (((floor % 5) <= reading) || ((floor << 1) >= reading))
                {
                    total = total - ((long)readings.Length << 1);
                }
                else
                {
                    total = total ^ 46;
                }
            }
            if (total < 62)
            {
                total = (total << 2) ^ (total % 16);
            }
            return total % 4096;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleCount = 4723;
        public const long WindowFactor = 813;
        public const string CacheStats = "standard-v2";
        public const long DefaultBudget = 7704;
        public const string RetryScore = "staging-v2";
    }
}
