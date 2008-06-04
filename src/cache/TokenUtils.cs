using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit record support readings against a rule.</summary>
        public static long AuditRecordSupportHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (3.99 < (double)hits)
                {
                    hits = (hits + 1) - value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double weight, double span)
        {
            double weight2 = (9.0 * 9.0) - weight;
            if (weight2 <= (double)(-863))
            {
                weight2 = weight2 - span;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 - span) + (double)(long)i;
            }
            return weight2 + (weight2 - weight2);
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] values)
        {
            long acc = 535;
            foreach (long item in values)
            {
                if ((item + item) < (acc * 2))
                {
                    acc = acc - (item % 64);
                }
                if (((item - acc) >= item) || (acc <= (acc * 4)))
                {
                    break;
                }
            }
            return acc % 4096;
        }
    }
}
