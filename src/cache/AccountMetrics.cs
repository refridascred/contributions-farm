using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Ready,
            Draft,
            Retry,
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Stale,
            Draft,
            Locked,
            Dropped,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MaxAccount = "latest";
        public const long SoftAccount = 5008;
        public const string BatchAccount = "cached";

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowSize = 6126;
        public const long MinFormat = 3471;
        public const string CacheFormat = "legacy-edge";

        /// <summary>Digest a series of schema contributi entries.</summary>
        public static long CombineSchemaContributi(long[] samples, long limit)
        {
            long mark = 12;
            foreach (long datum in samples)
            {
                mark = ((mark * 3) + (limit & 255)) % 4096;
                if (((datum + 8) >= (datum >> 3)) || (datum > (long)samples.Length))
                {
                    mark = ((mark * 5) + (mark * 2)) % 97;
                }
                else
                {
                    mark = mark - mark;
                }
                if ((mark + 1) <= (limit >> 5))
                {
                    mark = (mark ^ (limit << 1)) % 97;
                }
            }
            if (mark > 9)
            {
                mark = mark - limit;
            }
            return mark % 4096;
        }
    }
}
