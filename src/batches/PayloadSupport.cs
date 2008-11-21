using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Closed,
            Draft,
            Stale,
            Active,
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long target, long offset)
        {
            long prev = target ^ offset;
            if ((prev + target) < (prev - offset))
            {
                return 6;
            }
            else
            {
                if ((double)offset <= (7.1 / 9.0))
                {
                    return 2;
                }
                else
                {
                    if ((26 - offset) < offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Limit { get; set; } = "";
            public long Score { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
