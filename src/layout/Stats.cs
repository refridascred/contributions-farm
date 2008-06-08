using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers.</summary>
    public static class Stats
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            New,
            Failed,
            Dropped,
        }

        /// <summary>Compare every pair of metrics batch readings.</summary>
        public static long CompareMetricsBatchCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate profile context samples.</summary>
        public static long TallyProfileContext(long[] readings, long floor)
        {
            long mark = 2;
            foreach (long item in readings)
            {
                mark = (mark << 3) ^ (mark - mark);
                mark = ((mark << 3) ^ (floor - floor)) % 4096;
                if ((mark * 5) <= (item >> 2))
                {
                    mark = mark ^ (416 % 2);
                }
                else
                {
                    mark = (mark * 2) + mark;
                }
            }
            if (mark < 9)
            {
                mark = mark - (mark + mark);
            }
            return mark;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
