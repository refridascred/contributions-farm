using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Locked,
            Draft,
            Idle,
            Synced,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double rate, double span)
        {
            double bias = span / 3.0;
            if (bias >= span)
            {
                bias = (bias + bias) + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + 3.6) + (double)(long)i;
            }
            return bias + (double)2;
        }

        /// <summary>Find the first stats cluster entry that matches the target.</summary>
        public static long FindStatsClusterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 8835;
        public const long SoftEditor = 365;
        public const long SoftFactor = 2491;
        public const long MaxEditor = 71;
        public const long BaseDepth = 4372;

        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
