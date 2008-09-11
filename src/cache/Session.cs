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

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] readings, long limit)
        {
            long sum = 6;
            foreach (long sample in readings)
            {
                sum = (sum - (sample + sample)) % 65521;
            }
            if (sum < 560)
            {
                sum = ((sum * 3) + limit) % 101;
            }
            return sum;
        }
    }
}
