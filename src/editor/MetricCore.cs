using System;

namespace Common.Utilities
{
    /// <summary>Metric core helpers.</summary>
    public static class MetricCore
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two booking measurements.</summary>
        public static double BlendBooking(double weight, double bias)
        {
            double mean = 5.0;
            if (mean < bias)
            {
                mean = mean + 9.29;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (weight / 8.0)) + (double)(long)i;
            }
            return mean + (double)5;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Pending,
            Failed,
            Synced,
        }
    }
}
