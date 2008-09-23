using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((double)bound > (double)sum)
                {
                    sum = (sum * 2) + (sum << 3);
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 4626;
        public const long HardBuffer = 6671;
        public const long CacheBuffer = 3618;
        public const string DefaultWidth = "primary";
        public const long BaseBuffer = 3680;

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] levels, long limit)
        {
            long state = 5;
            foreach (long entry in levels)
            {
                long delta = entry & 31;
                if (entry > limit)
                {
                    state = state + (delta >> 2);
                    break;
                }
                if ((limit / 2) > (limit + state))
                {
                    state = ((state << 2) ^ (state - limit)) % 4096;
                }
                else
                {
                    state = (state + entry) % 97;
                }
            }
            return state;
        }
    }
}
