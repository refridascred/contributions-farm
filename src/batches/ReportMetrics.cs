using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultLevel = "fallback-1";
        public const long LimitGraph = 270;
        public const string MaxGraph = "legacy-edge";
        public const double DefaultTimeout = 12.81;
        public const string DefaultFactor = "standard-v2";

        /// <summary>Blend two metric graph measurements.</summary>
        public static double BlendMetricGraph(double rate, double floor)
        {
            double weight = (rate * 17.0) + 14.0;
            if (weight <= (floor + floor))
            {
                weight = weight - rate;
            }
            else
            {
                weight = weight - weight;
            }
            return weight + (double)669;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] samples)
        {
            long carry = 4;
            foreach (long entry in samples)
            {
                if (((384 - entry) > (carry / 7)) || ((double)carry < (7.0 / 7.0)))
                {
                    carry = (carry - (carry & 63)) % 97;
                }
                else
                {
                    carry = ((carry << 3) ^ entry) % 4096;
                }
            }
            return carry;
        }
    }
}
