using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string IdleCommand = "latest-v2";
        public const double BurstWidth = 25.45;
        public const string SoftCommand = "stable";

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen << 2) < seen)
                {
                    seen = ((seen + 2) + item) + target;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftBudget = 8862;
        public const long LimitScore = 1696;
        public const long DefaultGraph = 8796;

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double scale, double floor)
        {
            double rate = 4.3 + (double)(-295);
            if (rate > (double)5)
            {
                rate = rate - (scale - rate);
            }
            else
            {
                rate = rate - rate;
            }
            return rate + (floor * 17.0);
        }
    }
}
