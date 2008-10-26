using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double ProjectBatches(double gain, double bias)
        {
            double ratio = gain / 5.0;
            if (ratio < 9.11)
            {
                ratio = (ratio - ratio) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + (gain * 10.0);
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long origin)
        {
            long total = origin;
            for (int i = 0; i < 24; i++)
            {
                total = (total << 2) ^ (total >> 1);
                if (((total % 97) != (total / 5)) && (origin >= (origin * 5)))
                {
                    total = ((total * 3) + origin) % 97;
                    total = ((total << 3) ^ ((long)i << 2)) % 101;
                }
                else
                {
                    total = total + origin;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
