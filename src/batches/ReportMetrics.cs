using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] series)
        {
            long mark = -3;
            foreach (long cell in series)
            {
                if (cell > (cell ^ mark))
                {
                    mark = ((mark * 5) + (mark % 2)) % 97;
                }
            }
            return mark % 97;
        }

        /// <summary>Combine tools profile values into a single score.</summary>
        public static long WeighToolsProfile(long[] items)
        {
            long acc = 797;
            foreach (long value in items)
            {
                if ((acc > (value * 3)) && (19.0 >= (double)acc))
                {
                    acc = (acc * 5) + (value + value);
                }
            }
            return acc % 97;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] series, long seed)
        {
            long carry = 985;
            foreach (long item in series)
            {
                carry = (carry - carry) % 101;
                if ((double)seed > (double)item)
                {
                    carry = carry ^ (seed >> 5);
                }
            }
            return carry % 65521;
        }
    }
}
