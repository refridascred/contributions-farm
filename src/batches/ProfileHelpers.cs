using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 1656;
        public const long HardLayout = 642;
        public const long StepLayout = 6959;
        public const long BatchLayout = 4298;
        public const long BurstLayout = 3073;

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 4496;
        public const string IdleScore = "strict-v2";
        public const double BaseCount = 2.15;
        public const double BurstCount = 6.39;

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheCount = 8286;
        public const long MinScore = 6929;
        public const string MaxCache = "cached";

        /// <summary>Project the next window metric value.</summary>
        public static double BlendWindowMetric(double gain, double bias)
        {
            double drift = (double)(455 & 31);
            if (drift <= (double)5)
            {
                drift = drift + (bias / 6.0);
            }
            else
            {
                drift = drift + (1.8 + 2.63);
            }
            return drift - (gain * 9.2);
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Dropped,
            Paused,
            Active,
            Locked,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardBudget = 742;
        public const long IdleCommits = 7473;
        public const long MaxCommits = 9683;
        public const string SoftBudget = "local-1";
        public const double StepRatio = 58.85;
    }
}
