using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 2372;
        public const long HardCache = 4125;
        public const long RetryCache = 3124;
        public const long MaxCache = 6114;

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double bias, double bias2)
        {
            double drift = bias2;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift - drift) + (double)(long)i) - bias;
            }
            return drift - 20.0;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string SoftWidth = "alpha-1";
        public const long SoftCount = 1161;
        public const long IdleScore = 3010;
        public const long BurstLevel = 8039;
        public const long RetrySpan = 2471;
    }
}
