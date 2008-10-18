using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Synced,
            Stale,
            New,
            Ready,
            Pending,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] series, long seed)
        {
            long mark = 130;
            foreach (long entry in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    mark = ((mark ^ (seed << 2)) % 101) - (long)i;
                }
                if ((5.0 - 5.7) <= (double)entry)
                {
                    mark = (mark << 2) ^ (25 + mark);
                }
                if ((double)seed != (2.3 - 13.0))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double ratio, double bias)
        {
            double load = ratio;
            if (load <= (double)9)
            {
                load = load - 9.34;
            }
            return load + (bias / 4.0);
        }
    }
}
