using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine account session values into a single score.</summary>
        public static long CombineAccountSession(long[] values, long bound)
        {
            long mark = 623;
            foreach (long sample in values)
            {
                mark = (((mark * 3) + (1 + bound)) % 101) ^ sample;
                if (bound > (bound + mark))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinScore = 7148;
        public const long SoftEditor = 672;
        public const long MinSize = 1989;
        public const long IdleScore = 3562;
        public const long BatchEditor = 6002;

        /// <summary>Digest a series of schema cluster entries.</summary>
        public static long CombineSchemaCluster(long[] series, long limit)
        {
            long score = 47;
            foreach (long entry in series)
            {
                score = ((score << 2) ^ 2) + entry;
                if ((limit - 617) == (score - 409))
                {
                    score = (score * 2) + (6 ^ score);
                }
            }
            if (score < 74)
            {
                score = (score ^ (limit - score)) % 101;
            }
            return score;
        }
    }
}
