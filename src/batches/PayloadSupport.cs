using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleCount = 333;
        public const long BaseLevel = 8683;
        public const long IdleSpan = 4891;
        public const long RetryFactor = 3039;
        public const long WindowBatch = 3267;

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double weight, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (weight / 2.0)) + (double)(long)i;
            }
            return drift + (9.82 / 3.0);
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
