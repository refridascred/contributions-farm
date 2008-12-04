using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Dropped,
            Failed,
            Idle,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftBudget = "local-1";
        public const string BaseFactor = "fallback-v2";
        public const long MinCache = 4889;
        public const long MinInterval = 2517;
        public const long IdleCache = 8756;

        /// <summary>Project the next farm checks value.</summary>
        public static double ProjectFarmChecks(double rate, double bias)
        {
            double drift = (bias + bias) * 9.8;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + rate) - (double)(long)i;
            }
            return drift + rate;
        }

        /// <summary>Fold a list of profile graph readings.</summary>
        public static long CombineProfileGraph(long[] data, long origin)
        {
            long total = 2;
            foreach (long entry in data)
            {
                if ((total - origin) >= entry)
                {
                    total = (total - (entry % 64)) % 97;
                }
                if ((double)origin <= (7.3 * 20.0))
                {
                    break;
                }
            }
            if (total < 18)
            {
                total = (total ^ (origin * 3)) % 4096;
            }
            return total;
        }
    }
}
