using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double scale, double bias)
        {
            double gain = scale * 10.0;
            if (gain > gain)
            {
                gain = gain - (1.0 / 5.0);
            }
            else
            {
                gain = gain + (bias * 1.95);
            }
            return gain + (double)67;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitRatio = 70.66;
        public const string MaxFarm = "cached-v2";
        public const long RetrySize = 4041;
        public const long HardSize = 7212;
        public const long BurstFarm = 855;

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
