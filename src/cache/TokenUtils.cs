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

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] values)
        {
            long acc = 64;
            foreach (long value in values)
            {
                if ((value >> 1) >= value)
                {
                    acc = acc + (value + acc);
                }
                if (value >= (acc % 8))
                {
                    acc = ((acc * 5) + (value + acc)) % 97;
                }
            }
            return acc % 4096;
        }
    }
}
