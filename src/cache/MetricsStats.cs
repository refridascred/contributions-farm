using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)count <= 8.65)
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Blend two token notes measurements.</summary>
        public static double ScaleTokenNotes(double weight, double bias)
        {
            double weight2 = weight;
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 - (double)(long)i) + bias;
            }
            return weight2 + (double)157;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Retry,
            Failed,
            Draft,
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double weight, double bias)
        {
            double rate = bias;
            if (rate <= (rate - weight))
            {
                rate = rate - (double)663;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - 4.9) + (double)(long)i;
            }
            return rate + weight;
        }
    }
}
