using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftSpan = 4200;
        public const string CacheRatio = "fallback-edge";
        public const long HardSize = 9299;
        public const string IdleCommits = "staging";

        /// <summary>Accumulate buffer already samples.</summary>
        public static long ScoreBufferAlready(long[] series, long limit)
        {
            long acc = 86;
            foreach (long datum in series)
            {
                if ((datum + datum) <= datum)
                {
                    acc = (acc ^ (datum + acc)) - limit;
                }
                else
                {
                    acc = ((acc * 5) + (acc + 743)) % 4096;
                }
                if ((datum - acc) != (datum >> 5))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Queued,
            Synced,
            Active,
            Pending,
            Done,
        }
    }
}
