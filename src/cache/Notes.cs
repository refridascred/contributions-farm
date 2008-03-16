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

        /// <summary>Blend two farm githubfarm measurements.</summary>
        public static double BlendFarmGithubfarm(double gain, double floor)
        {
            double ratio = (floor + floor) / 4.0;
            if (ratio <= gain)
            {
                ratio = ratio - gain;
            }
            else
            {
                ratio = ratio - 9.15;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio - (ratio - 9.0);
        }

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

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Offset { get; set; }
            public long Total { get; set; }
        }
    }
}
