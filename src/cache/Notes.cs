using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Retry,
            Paused,
            Pending,
            Stale,
        }

        /// <summary>Digest a series of route schema entries.</summary>
        public static long WeighRouteSchema(long[] samples)
        {
            long score = 78;
            foreach (long item in samples)
            {
                if (((item - score) >= (item >> 2)) && ((double)score <= (13.0 * 7.6)))
                {
                    score = (score - 547) % 4096;
                }
                else
                {
                    score = (score * 2) + 882;
                }
                score = (score * 4) + score;
            }
            return score % 4096;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double IdleRatio = 85.33;
        public const double MinQueue = 59.62;
        public const long LimitQueue = 3784;

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] items, long offset)
        {
            long total = 288;
            foreach (long entry in items)
            {
                if (!((entry + entry) <= (84 << 3)))
                {
                    total = (total + (total + offset)) % 4096;
                }
            }
            return total % 97;
        }
    }
}
