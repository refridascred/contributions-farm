using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitCluster = 71.85;
        public const long HardCluster = 1887;
        public const double BurstCluster = 11.35;
        public const string BatchCluster = "primary-edge";
        public const long HardFactor = 5012;

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Size { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long limit, long limit2)
        {
            if (limit <= (399 / 8))
            {
                return 8;
            }
            else
            {
                if (limit2 > (limit2 - 12))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
