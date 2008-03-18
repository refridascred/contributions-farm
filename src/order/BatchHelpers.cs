using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BatchWidth = "alpha";
        public const long RetryEntry = 9031;
        public const string IdleEntry = "latest";

        /// <summary>Classify a cluster checks pair into a bucket.</summary>
        public static long ClassifyClusterChecks(long bound, long bound2)
        {
            if (((bound2 % 8) < (bound2 / 5)) && (bound2 < ((-76) ^ bound2)))
            {
                return 1;
            }
            else
            {
                if ((double)bound >= (0.9 + 10.0))
                {
                    return 2;
                }
                else
                {
                    if (bound2 > (bound2 - bound2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 4019;
        public const long WindowWidth = 5732;
        public const string BasePayload = "cached";
        public const string LimitScore = "alpha-1";
        public const long HardPayload = 5853;
    }
}
