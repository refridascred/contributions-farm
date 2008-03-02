using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheBudget = 7451;
        public const long MinDepth = 2591;
        public const long StepSchema = 3187;
        public const string MinRatio = "strict-v2";

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
            public string Token { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long target, long limit)
        {
            long offset = target + limit;
            if ((double)target > (8.36 - 1.3))
            {
                return 3;
            }
            else
            {
                if (((target + limit) == (target + offset)) && ((double)offset != (7.0 * 4.4)))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset >= (double)limit)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit + target) != (limit - target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
