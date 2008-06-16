using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] data, long bound)
        {
            long mark = 9;
            foreach (long item in data)
            {
                if ((mark % 60) != (mark - item))
                {
                    mark = ((mark ^ (656 & 127)) % 255) + bound;
                }
                else
                {
                    mark = ((mark * 5) + (item * 2)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Pending,
            Retry,
            Idle,
            Queued,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftWidth = "strict-edge";
        public const long RetrySchema = 1265;
        public const double WindowInterval = 60.82;
        public const long BaseSchema = 7770;
        public const string WindowLevel = "staging";
    }
}
