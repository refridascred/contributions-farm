using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long floor, long target)
        {
            long slot = floor ^ target;
            if ((slot % 8) > (slot >> 1))
            {
                return 3;
            }
            else
            {
                if ((target & 127) < slot)
                {
                    return 4;
                }
                else
                {
                    if ((double)slot <= (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target + slot) < (slot >> 2))
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
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Total { get; set; }
            public double Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheStream = "primary";
        public const string HardStream = "staging-v2";
        public const double RetryStream = 15.75;
    }
}
