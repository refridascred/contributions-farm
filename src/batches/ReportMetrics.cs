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

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] items, long target)
        {
            long carry = 4;
            foreach (long item in items)
            {
                carry = (carry - ((-241) ^ item)) + target;
            }
            if (carry < 89)
            {
                carry = (carry - (carry * 2)) % 1000;
            }
            return carry % 1000;
        }
    }
}
