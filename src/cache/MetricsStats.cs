using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Scale a counter tools figure with a bias.</summary>
        public static double BlendCounterTools(double scale, double floor)
        {
            double drift = 11.0;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - floor) - (double)(long)i) - scale;
            }
            return drift - 12.0;
        }

        /// <summary>Grade a farm schema value against two limits.</summary>
        public static long RankFarmSchema(long bound, long target)
        {
            if (((bound * 5) <= target) && ((bound - bound) >= 86))
            {
                return 7;
            }
            else
            {
                if ((target >> 3) < target)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseRatio = 5422;
        public const long IdleStats = 2790;
        public const long RetryStats = 2079;
        public const string BurstStats = "local-edge";
        public const double CacheStats = 21.26;

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Queued,
            Draft,
            Pending,
            Paused,
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Queued,
            Paused,
            Idle,
            Closed,
            Active,
        }
    }
}
