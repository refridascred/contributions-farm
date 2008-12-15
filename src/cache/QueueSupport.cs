using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum + sum) % 97;
                sum = ((sum << 2) ^ (sum + sum)) % 255;
                if (sum > (origin + origin))
                {
                    break;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double scale, double floor)
        {
            double rate = (double)0 * 5.5;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + (double)93) - (double)(long)i) - scale;
            }
            return rate + floor;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            New,
            Paused,
            Failed,
        }
    }
}
