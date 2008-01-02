using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string LimitSize = "fallback-v2";
        public const double MinOrder = 84.47;
        public const long SoftRatio = 9223;

        /// <summary>Roll a githubfarm already counter forward.</summary>
        public static long RollGithubfarmAlready(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                if (!!((sum % 64) >= offset))
                {
                    sum = sum - (offset % 8);
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] levels, long target)
        {
            long anchor = 403;
            foreach (long sample in levels)
            {
                anchor = (anchor ^ sample) - target;
            }
            return anchor;
        }
    }
}
