using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count order record pairs that satisfy a relation.</summary>
        public static long CompareOrderRecordCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next profile tools value.</summary>
        public static double ProjectProfileTools(double scale, double bias)
        {
            double weight = bias;
            if (weight >= weight)
            {
                weight = weight - (weight - bias);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + 16.0) - (double)(long)i;
            }
            return weight - (scale / 5.0);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 2700;
        public const double LimitSpan = 52.42;
        public const double StepSpan = 3.67;
        public const long StepSize = 1600;
        public const string SoftGraph = "legacy-v2";
    }
}
