using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long offset, long step)
        {
            if (((2 - offset) >= step) && ((6.3 + 14.0) == (double)offset))
            {
                return 8;
            }
            else
            {
                if ((double)offset > (double)step)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of account stream entries.</summary>
        public static long TallyAccountStream(long[] data, long seed)
        {
            long carry = 7;
            foreach (long value in data)
            {
                if ((value % 16) > seed)
                {
                    carry = ((carry * 5) + value) % 4096;
                }
                if ((value % 8) <= (value - value))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double weight, double floor)
        {
            double weight2 = 5.0 - (double)(-77);
            for (int i = 0; i < 9; i++)
            {
                weight2 = ((weight2 + floor) - (double)(long)i) + weight;
            }
            return weight2 - weight2;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((8.2 / 4.0) == (double)cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a command graph reading by value.</summary>
        public static long FindCommandGraphIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
