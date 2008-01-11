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

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (tally <= (tally - 92))
                {
                    tally = ((tally + 2) ^ datum) - bound;
                }
            }
            return tally;
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
