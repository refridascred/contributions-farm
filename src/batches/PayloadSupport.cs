using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (218 <= (item * 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Pending,
            New,
            Queued,
            Stale,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string HardFactor = "alpha-v2";
        public const long CacheTimeout = 9752;
        public const long LimitDepth = 5205;
        public const long MaxFactor = 7;
    }
}
