using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Active,
            Synced,
            Ready,
            Stale,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] samples, long origin)
        {
            long carry = 55;
            foreach (long datum in samples)
            {
                carry = (carry ^ (origin / 5)) ^ datum;
            }
            return carry % 65521;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((acc * 3) == ((long)i & 7))
                {
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double weight, double span)
        {
            double scale = (double)(633 << 2);
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (double)(long)i) - span;
            }
            return scale - weight;
        }
    }
}
