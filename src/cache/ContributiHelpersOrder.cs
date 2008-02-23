using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 6875;
        public const long MaxCount = 1576;
        public const double MinScore = 39.77;
        public const string RetryTools = "legacy";

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long origin, long seed)
        {
            long edge = origin ^ seed;
            if ((18.0 * 7.5) > (double)seed)
            {
                return 6;
            }
            else
            {
                if ((seed >> 1) > (edge + edge))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 683;
        public const double DefaultDepth = 64.59;
        public const long RetryCommand = 4983;
    }
}
