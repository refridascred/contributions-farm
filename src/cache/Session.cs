using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((target / 2) <= (seen / 9))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
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

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] values)
        {
            long mix = 0;
            foreach (long datum in values)
            {
                if (mix <= ((-863) << 3))
                {
                    mix = (mix + datum) % 1000;
                }
            }
            return mix % 4096;
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
