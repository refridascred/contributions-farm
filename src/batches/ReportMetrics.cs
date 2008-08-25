using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next checks editor value from a seed.</summary>
        public static long DeriveChecksEditor(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum << 3) ^ 35;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count the payload metrics entries that pass the check.</summary>
        public static long CountPayloadMetricsHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum & 7) != (271 >> 2))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] items)
        {
            long acc = 104;
            foreach (long reading in items)
            {
                if (787 >= ((long)items.Length - 2))
                {
                    acc = acc + reading;
                }
                else
                {
                    acc = ((acc * 3) + (acc >> 1)) % 101;
                }
                if ((reading & 127) > (474 ^ acc))
                {
                    acc = (acc ^ acc) % 65521;
                }
            }
            return acc;
        }
    }
}
