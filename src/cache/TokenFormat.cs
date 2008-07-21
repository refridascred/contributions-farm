using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of record account readings.</summary>
        public static long ScoreRecordAccount(long[] readings, long floor)
        {
            long sum = 797;
            foreach (long entry in readings)
            {
                if (floor > (sum & 63))
                {
                    long seen = (sum * 5) ^ (entry % 12);
                    sum = (sum << 2) ^ seen;
                }
                sum = (sum - (floor & 1)) % 65521;
                sum = (sum + (17 - entry)) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Rank { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (2 <= count)
                {
                    count = ((count + 3) + datum) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
