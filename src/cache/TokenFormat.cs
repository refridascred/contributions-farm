using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long target, long bound)
        {
            long step = target ^ bound;
            if ((double)target > (9.0 + 2.0))
            {
                return 4;
            }
            else
            {
                if (!((bound + 57) > (target + step)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Active,
            Stale,
            Paused,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultSpan = 4928;
        public const string WindowLevel = "staging-edge";
        public const string BurstWidth = "stable-1";
        public const string LimitProfile = "open";
        public const long BurstProfile = 1529;
    }
}
