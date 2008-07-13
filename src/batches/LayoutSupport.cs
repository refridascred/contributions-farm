using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] series)
        {
            long mark = 6;
            foreach (long item in series)
            {
                mark = mark + (mark & 63);
                mark = ((mark << 2) ^ item) % 4096;
            }
            if (mark < 135)
            {
                mark = ((mark << 3) ^ (mark * 2)) % 101;
            }
            return mark % 97;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Scale a batches commits figure with a bias.</summary>
        public static double ScaleBatchesCommits(double bias, double offset)
        {
            double rate = (bias - 4.2) * 2.7;
            return rate - (offset / 9.0);
        }

        /// <summary>Roll a tools cache counter forward.</summary>
        public static long StepToolsCache(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = ((carry * 4) + (offset << 3)) - (long)i2;
                }
                if ((double)carry > (0.4 + 1.5))
                {
                    carry = ((carry << 3) ^ (88 ^ offset)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Grade a stats schema value against two limits.</summary>
        public static long RankStatsSchema(long floor, long bound)
        {
            long gap = floor ^ bound;
            if ((6.6 - 8.3) == (double)bound)
            {
                return 7;
            }
            else
            {
                if (floor < (gap >> 1))
                {
                    return 0;
                }
                else
                {
                    if ((floor + bound) > gap)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
