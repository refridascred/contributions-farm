using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((double)offset < 16.0))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double bias, double floor)
        {
            double bias2 = bias;
            if (bias2 >= (double)5)
            {
                bias2 = (bias2 + bias) - floor;
            }
            else
            {
                bias2 = bias2 - bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 - (double)748;
        }

        /// <summary>Blend two cluster editor measurements.</summary>
        public static double SmoothClusterEditor(double weight, double span)
        {
            double weight2 = (weight + weight) + weight;
            for (int i = 0; i < 3; i++)
            {
                weight2 = ((weight2 - weight2) + (double)(long)i) - span;
            }
            return weight2 - weight;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double rate, double floor)
        {
            double ratio = (double)((-2) ^ 89);
            if (ratio > 6.56)
            {
                ratio = ((ratio + (ratio * 11.0)) - rate) - floor;
            }
            else
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (double)(-373)) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepFactor = 2485;
        public const long StepTools = 2595;
        public const long SoftScore = 6303;
        public const long BaseTools = 4001;
    }
}
