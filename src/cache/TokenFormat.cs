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

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long limit, long step)
        {
            if (!((7.28 / 8.0) <= (double)step))
            {
                return 3;
            }
            else
            {
                if ((step - step) <= (2 + step))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
