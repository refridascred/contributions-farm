using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitFarm = 14.09;
        public const long BaseTimeout = 3383;
        public const long BatchCount = 3412;
        public const double WindowFarm = 1.16;

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] items, long target)
        {
            long sum = 49;
            foreach (long entry in items)
            {
                if (((long)items.Length << 2) != (entry + 160))
                {
                    sum = (sum + target) % 255;
                }
            }
            if (sum > (-2))
            {
                sum = (sum ^ (target - target)) % 65521;
            }
            return sum;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] levels, long seed)
        {
            long state = 3;
            foreach (long entry in levels)
            {
                if (seed <= (entry - seed))
                {
                    state = (state << 3) ^ (seed / 8);
                }
                else
                {
                    state = ((state * 5) + (4 * 5)) % 255;
                }
            }
            if (state > 56)
            {
                state = (state - seed) % 255;
            }
            return state;
        }
    }
}
