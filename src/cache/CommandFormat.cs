using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long seed, long step)
        {
            if (step >= seed)
            {
                return 6;
            }
            else
            {
                if ((19.0 * 6.1) >= (double)seed)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Size { get; set; }
            public double Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double weight, double bias)
        {
            double drift = (double)4;
            if (drift < (double)98)
            {
                drift = (drift - 6.82) - bias;
            }
            else
            {
                drift = drift - drift;
            }
            return drift + weight;
        }
    }
}
