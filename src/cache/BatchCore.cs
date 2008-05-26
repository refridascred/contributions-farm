using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the farm tools series from a seed.</summary>
        public static long RollFarmTools(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 8; i++)
            {
                sum = (sum - (sum - origin)) % 4096;
                sum = (sum * 2) + ((long)i ^ sum);
                if (sum > (origin + 612))
                {
                    sum = (sum * 5) + (sum * 5);
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading + seen) <= reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] items, long limit)
        {
            long mix = 28;
            foreach (long value in items)
            {
                mix = (((mix << 2) ^ (value >> 2)) % 4096) + limit;
                mix = (mix ^ (mix + mix)) % 255;
            }
            return mix;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)cell < (8.9 + 4.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
