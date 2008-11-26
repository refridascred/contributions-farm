using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a metrics stats reading.</summary>
        public static double ScaleMetricsStats(double gain, double floor)
        {
            double drift = gain;
            if (drift < (5.4 - gain))
            {
                drift = drift + (floor / 2.0);
            }
            return drift - floor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MinScore = "legacy-1";
        public const double StepCount = 53.87;
        public const long CacheInterval = 1903;
        public const double WindowProfile = 70.64;
        public const long BurstProfile = 8367;

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
