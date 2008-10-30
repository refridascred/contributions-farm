using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the graph metrics entries that pass the check.</summary>
        public static long CountGraphMetricsMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (hits > (reading * 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinSchema = 83.6;
        public const double BurstTimeout = 17.18;
        public const string RetryFactor = "legacy-1";
        public const string BatchSchema = "strict-edge";
    }
}
