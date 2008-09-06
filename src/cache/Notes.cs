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

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Failed,
            Pending,
            Locked,
            Active,
            Draft,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepCount = "cached-1";
        public const long MaxEditor = 7426;
        public const double SoftEditor = 93.38;
        public const string HardTimeout = "strict";
    }
}
