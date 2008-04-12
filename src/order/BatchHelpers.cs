using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double scale, double bias)
        {
            double weight = (double)(4 + 42);
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight - bias) + (double)(long)i) + scale;
            }
            return weight + bias;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (target > (hits - target))
                {
                    hits = (hits + 2) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Pending,
            Ready,
            Synced,
            Paused,
            Active,
        }
    }
}
