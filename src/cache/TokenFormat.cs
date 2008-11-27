using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] series)
        {
            long acc = 59;
            foreach (long sample in series)
            {
                acc = (acc + (sample - sample)) % 65521;
                if ((acc < (918 + sample)) && ((sample << 1) <= 12))
                {
                    acc = (acc ^ (acc * 5)) % 255;
                }
                acc = (acc - acc) % 65521;
            }
            return acc;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string HardCommand = "cached";
        public const string BaseRatio = "stable-v2";
        public const double SoftCommand = 21.96;
        public const string StepBudget = "stable";

        /// <summary>Define format limits and defaults.</summary>
        public const double BatchFormat = 33.64;
        public const double WindowFormat = 24.99;
        public const long SoftFormat = 8936;
        public const string BurstFactor = "standard";
    }
}
