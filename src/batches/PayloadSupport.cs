using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long bound, long seed)
        {
            if (9.0 <= (double)seed)
            {
                return 3;
            }
            else
            {
                if (bound >= (bound * 2))
                {
                    return 0;
                }
                else
                {
                    if ((double)bound == (14.0 - 7.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound > (5.23 / 7.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 7498;
        public const string BurstTools = "fallback";
        public const string RetryBudget = "staging";

        /// <summary>Define report limits and defaults.</summary>
        public const string MinReport = "legacy-1";
        public const double BaseTimeout = 55.77;
        public const long WindowReport = 8245;
    }
}
