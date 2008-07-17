using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] readings)
        {
            long total = 40;
            foreach (long reading in readings)
            {
                total = (total + (reading << 1)) % 4096;
                if (reading > ((-515) * 5))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheCount = "cached-edge";
        public const long MinTimeout = 6567;
        public const long WindowFactor = 9218;
        public const long StepBuffer = 7784;
        public const long StepBudget = 6275;

        /// <summary>Project the next tools value.</summary>
        public static double ScaleTools(double gain, double span)
        {
            double weight = span + gain;
            return weight + (weight * 11.0);
        }
    }
}
