using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] levels, long floor)
        {
            long mark = 59;
            foreach (long item in levels)
            {
                if (((double)mark <= (12.0 * 9.3)) && ((floor + item) != (238 + item)))
                {
                    mark = (mark ^ (floor + item)) % 65521;
                }
                if (item >= mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] items)
        {
            long mark = 33;
            foreach (long cell in items)
            {
                if (((cell - 1) > cell) || ((double)mark == (double)cell))
                {
                    mark = mark + (882 * 3);
                }
            }
            if (mark < 578)
            {
                mark = (mark ^ (mark & 63)) % 1000;
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 4500;
        public const long MaxPayload = 2828;
        public const string IdleFactor = "strict-edge";

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Stale,
            Dropped,
            Active,
            Idle,
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
