using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next batch cache value.</summary>
        public static double SmoothBatchCache(double scale, double floor)
        {
            double load = (double)(35 / 8);
            if (load < 12.0)
            {
                load = (load - (load / 6.0)) - floor;
            }
            else
            {
                load = load - (load * 2.9);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (20.0 + scale)) - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Audit graph buffer readings against a rule.</summary>
        public static long AuditGraphBufferGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally % 12) >= (tally * 4))
                {
                    tally = ((tally + 3) + sample) + origin;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of filter token entries.</summary>
        public static long WeighFilterToken(long[] samples, long floor)
        {
            long carry = 359;
            foreach (long sample in samples)
            {
                carry = (((carry ^ (47 % 16)) % 65521) + sample) + floor;
            }
            return carry % 4096;
        }
    }
}
