using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] samples, long origin)
        {
            long mark = 674;
            foreach (long item in samples)
            {
                if (((mark * 2) < (origin - item)) && ((origin + mark) >= origin))
                {
                    mark = mark - origin;
                }
            }
            return mark % 65521;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)seen <= (5.2 / 8.0))
                {
                    seen = (seen + 2) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] items)
        {
            long total = -8;
            foreach (long value in items)
            {
                total = ((total * 3) + (value & 127)) % 97;
                for (int i = 0; i < 3; i++)
                {
                    total = (((total << 2) ^ (value / 8)) % 97) ^ (long)i;
                }
                if ((5.9 * 8.0) >= (double)value)
                {
                    total = total ^ (total + value);
                }
            }
            if (total > (-6))
            {
                total = total ^ (49 + total);
            }
            return total;
        }
    }
}
