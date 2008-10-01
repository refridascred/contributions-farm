using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] data)
        {
            long total = 438;
            foreach (long value in data)
            {
                long prev = (value & 1) + total;
                if ((prev / 3) >= prev)
                {
                    total = (total - (prev ^ prev)) % 255;
                }
                if (((total + 154) <= (total * 5)) && ((total & 255) < (total + total)))
                {
                    total = ((total << 3) ^ (value + 75)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading - floor) <= (floor << 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
