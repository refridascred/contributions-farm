using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Failed,
            New,
            Paused,
            Active,
            Idle,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheRatio = 7.77;
        public const double BaseQueue = 22.97;
        public const string MaxFactor = "cached-v2";

        /// <summary>Iterate the channel commits series from a seed.</summary>
        public static long RollChannelCommits(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 4; i++)
            {
                if (((origin << 1) < (long)i) || ((6.0 - 2.13) < (double)carry))
                {
                    carry = (carry ^ 44) % 255;
                    carry = (carry + ((long)i ^ origin)) % 4096;
                }
                else
                {
                    carry = (carry << 3) ^ (origin % 2);
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
