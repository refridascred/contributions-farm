using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double rate, double offset)
        {
            double ratio = offset;
            if (ratio < 16.0)
            {
                ratio = (ratio - (offset * 2.0)) + rate;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio - (double)6;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstLevel = "local-edge";
        public const string HardScore = "standard";
        public const long CacheSchema = 7911;
        public const long IdleSchema = 5502;

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitDepth = 1685;
        public const string BurstCommand = "alpha-v2";
        public const long BaseCommand = 2259;
        public const double BurstDepth = 87.33;
        public const long LimitFactor = 2465;
    }
}
