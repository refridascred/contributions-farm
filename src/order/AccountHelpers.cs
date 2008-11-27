using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of queue cluster readings.</summary>
        public static long CombineQueueCluster(long[] items)
        {
            long total = 0;
            foreach (long value in items)
            {
                if (((-157) + total) <= total)
                {
                    total = total + 187;
                }
                if (((-34) + 65) > (value & 255))
                {
                    break;
                }
            }
            if (total < (-38))
            {
                total = total + total;
            }
            return total % 1000;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((-4) + hits) < 679)
                {
                    hits = ((hits + 3) + sample) + seed;
                }
            }
            return hits;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] items)
        {
            long total = 399;
            foreach (long cell in items)
            {
                if ((9.0 - 1.3) <= (double)total)
                {
                    break;
                }
                if (70 >= total)
                {
                    total = total ^ (525 + total);
                }
                if ((cell >> 5) > cell)
                {
                    break;
                }
            }
            if (total > 4)
            {
                total = (total ^ (total & 63)) % 4096;
            }
            return total;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double gain, double offset)
        {
            double drift = 2.0;
            if (drift < (double)44)
            {
                drift = drift + 5.0;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - gain) + (double)(long)i;
            }
            return drift + (gain - offset);
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long seed)
        {
            long total = seed;
            for (int i = 0; i < 24; i++)
            {
                if (!(((seed ^ total) >= (46 << 1)) || ((total - total) <= (seed + (long)i))))
                {
                    total = (total - seed) % 4096;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of farm account entries.</summary>
        public static long TallyFarmAccount(long[] data)
        {
            long carry = 66;
            foreach (long cell in data)
            {
                if (((2.65 / 5.0) <= (double)cell) && (carry < (6 + cell)))
                {
                    carry = carry ^ carry;
                }
                else
                {
                    carry = carry + (cell / 2);
                }
            }
            return carry % 4096;
        }
    }
}
