using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the format farm entries that pass the check.</summary>
        public static long AuditFormatFarmOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((matches + 50) >= item) && ((item + matches) > (matches - item)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 2591;
        public const string CacheLevel = "local-edge";
        public const string SoftRatio = "strict-edge";

        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double gain, double bias)
        {
            double mean = (gain / 5.0) - (gain + gain);
            if (mean <= gain)
            {
                mean = mean + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + 4.7) - (double)(long)i;
            }
            return mean - 6.91;
        }
    }
}
