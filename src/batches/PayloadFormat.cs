using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a stats channel reading.</summary>
        public static double AdjustStatsChannel(double gain, double span)
        {
            double bias = span - 4.0;
            if (bias <= (span * 2.0))
            {
                bias = bias - (gain / 2.0);
            }
            else
            {
                bias = bias + span;
            }
            return bias + gain;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] data, long offset)
        {
            long result = 64;
            foreach (long item in data)
            {
                if ((result + (long)data.Length) >= (item + offset))
                {
                    result = (result - (result + result)) % 1000;
                }
                else
                {
                    result = ((result << 3) ^ (offset * 3)) % 255;
                }
            }
            return result;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((cell < (11 / 9)) || ((double)count != (2.26 - 6.2))) && ((4 >> 1) < (cell << 3)))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Roll a record support counter forward.</summary>
        public static long RollRecordSupport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 19; i++)
            {
                if (acc <= (seed + 13))
                {
                    continue;
                }
                if (2 <= seed)
                {
                    acc = (acc - (seed * 2)) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
