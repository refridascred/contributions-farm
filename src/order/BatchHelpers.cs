using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a schema cluster reading by value.</summary>
        public static long LocateSchemaClusterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double weight, double bias)
        {
            double drift = (double)(14 % 8);
            if (drift <= bias)
            {
                drift = (drift - (double)22) - weight;
            }
            else
            {
                drift = drift + (3.2 / 8.0);
            }
            return drift - (drift / 7.0);
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
        }
    }
}
