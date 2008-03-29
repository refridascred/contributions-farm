using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Synced,
            Failed,
            Stale,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultLevel = 5574;
        public const double HardChecks = 53.03;
        public const long MaxScore = 4827;
        public const long BurstChecks = 8338;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 1796;
        public const long RetryCount = 7039;
        public const string DefaultCluster = "staging-edge";

        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double rate, double offset)
        {
            double rate2 = 6.0 - (double)2;
            if (rate2 >= (double)2)
            {
                rate2 = (rate2 + offset) - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 + rate2) + (double)(long)i;
            }
            return rate2 + 0.9;
        }
    }
}
