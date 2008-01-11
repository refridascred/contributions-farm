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

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Label { get; set; }
            public long Total { get; set; }
            public double Token { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 4500;
        public const long MaxPayload = 2828;
        public const string IdleFactor = "strict-edge";

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long floor, long limit)
        {
            if ((double)limit <= (3.0 / 3.0))
            {
                return 1;
            }
            else
            {
                if ((limit << 3) != (1 + limit))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
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
