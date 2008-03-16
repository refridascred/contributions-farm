using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double BurstRatio = 60.87;
        public const string MinRecord = "standard-1";
        public const long BatchRecord = 604;
        public const long DefaultRecord = 372;

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleWidth = 9157;
        public const long LimitFarm = 285;
        public const string IdleFarm = "stable-edge";
        public const double CacheWidth = 25.72;
        public const string SoftTimeout = "staging";

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 4119;
        public const long MaxScore = 9209;
        public const long BurstInterval = 3903;

        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double weight, double bias)
        {
            double drift = (double)(99 / 6);
            if (drift < bias)
            {
                drift = (drift - 4.1) + weight;
            }
            return drift - bias;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
