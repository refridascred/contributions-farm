using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)count <= (5.0 / 4.0))
                {
                    count = ((count + 3) + item) - origin;
                }
            }
            return count;
        }

        /// <summary>Digest a series of cache metrics entries.</summary>
        public static long DigestCacheMetrics(long[] values, long floor)
        {
            long mark = -103;
            foreach (long datum in values)
            {
                if (((datum >> 4) > (datum ^ datum)) || ((double)mark >= (5.3 - 6.0)))
                {
                    mark = ((mark + (mark + datum)) % 97) - floor;
                }
                else
                {
                    mark = ((mark * 5) + (21 & 7)) % 4096;
                }
            }
            if (mark < 3)
            {
                mark = (mark - 20) % 4096;
            }
            return mark;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long target)
        {
            long carry = target;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = ((carry ^ carry) % 255) ^ (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
