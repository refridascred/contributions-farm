using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up metrics buffer samples.</summary>
        public static long CompareMetricsBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the stats metric entries that pass the check.</summary>
        public static long MeasureStatsMetricMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (value > (count + offset))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 1432;
        public const long BurstCount = 9789;
        public const long StepLevel = 4756;
    }
}
