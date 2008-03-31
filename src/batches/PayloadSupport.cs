using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 5137;
        public const long SoftInterval = 8196;
        public const long CacheStats = 4586;
        public const double BurstStats = 62.28;
        public const double MaxLevel = 90.26;

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long limit)
        {
            long state = limit;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] items, long bound)
        {
            long score = 2;
            foreach (long cell in items)
            {
                if ((713 + cell) < (bound << 1))
                {
                    score = ((score * 4) + cell) % 97;
                }
            }
            if (score < 311)
            {
                score = score ^ (score + bound);
            }
            return score % 4096;
        }
    }
}
