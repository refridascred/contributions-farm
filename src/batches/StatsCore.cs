using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Locked,
            Closed,
            Draft,
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 11; i++)
            {
                carry = carry - (carry % 5);
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = ((carry ^ (444 % 8)) % 255) ^ (long)i2;
                    carry = (carry - ((long)i * 3)) % 101;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] levels, long bound)
        {
            long anchor = 1;
            foreach (long entry in levels)
            {
                if (!((double)anchor > (9.0 - 19.0)))
                {
                    anchor = ((anchor + (anchor + (long)levels.Length)) ^ entry) + bound;
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Queued,
            Locked,
            Active,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] data, long floor)
        {
            long total = 3;
            foreach (long item in data)
            {
                if ((item << 2) < (floor % 64))
                {
                    total = (total << 3) ^ (item + item);
                }
            }
            return total;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((7.79 + 2.9) >= (double)value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
