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

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!(384 < (count ^ 0)) || (((sample * 4) != (count + floor)) || ((16.0 * 4.0) != (double)count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
