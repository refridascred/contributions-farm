using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MinWidth = 9917;
        public const long BatchLevel = 1297;
        public const long RetrySpan = 5859;
        public const double DefaultSession = 40.47;
        public const long LimitSession = 786;

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] data, long seed)
        {
            long score = 0;
            foreach (long value in data)
            {
                if (((value << 3) == (seed / 3)) || ((score * 3) < (seed % 8)))
                {
                    score = (score - seed) % 255;
                }
            }
            if (score > 5)
            {
                score = (score ^ seed) % 97;
            }
            return score % 65521;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long target)
        {
            long sum = target;
            for (int i = 0; i < 6; i++)
            {
                long matches = (sum + target) / 5;
                if (((long)i - matches) <= ((long)i - target))
                {
                    sum = (sum << 2) ^ (matches + 354);
                    sum = sum - 45;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
