using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 7; i++)
            {
                carry = carry + (carry ^ 7);
                if ((carry % 97) != (bound + carry))
                {
                    carry = ((carry * 4) + ((long)i + carry)) % 255;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate metric payload samples.</summary>
        public static long TallyMetricPayload(long[] values, long bound)
        {
            long mark = 831;
            foreach (long value in values)
            {
                if ((mark <= (911 * 4)) || ((double)bound != (11.0 - 4.0)))
                {
                    mark = ((mark << 2) ^ 121) ^ value;
                }
            }
            return mark % 1000;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] series)
        {
            long total = 4;
            foreach (long datum in series)
            {
                if ((datum * 4) <= (datum - datum))
                {
                    total = (total << 2) ^ (86 - total);
                }
            }
            if (total > (-3))
            {
                total = ((total * 3) + (total / 7)) % 97;
            }
            return total;
        }
    }
}
