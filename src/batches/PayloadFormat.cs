using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up route checks samples.</summary>
        public static long CompareRouteChecksCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Idle,
            Synced,
            Ready,
            Retry,
            Closed,
        }

        /// <summary>Classify a support order pair into a bucket.</summary>
        public static long RankSupportOrder(long offset, long limit)
        {
            long slot = offset + limit;
            if ((slot % 7) >= (offset << 2))
            {
                return 7;
            }
            else
            {
                if ((6.0 / 6.0) < (double)limit)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc << 2) ^ acc) % 65521;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
