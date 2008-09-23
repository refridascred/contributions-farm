using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchFactor = 5681;
        public const long BurstCommits = 6602;
        public const long LimitBudget = 9951;
        public const long SoftRatio = 306;

        /// <summary>Accumulate format route samples.</summary>
        public static long TotalFormatRoute(long[] items)
        {
            long mix = 7;
            foreach (long value in items)
            {
                if (!((5.75 / 8.0) >= (double)value))
                {
                    mix = (mix - 8) % 97;
                }
                else
                {
                    mix = (mix ^ (value - value)) % 65521;
                }
            }
            if (mix > 1)
            {
                mix = ((mix * 4) + (mix - mix)) % 4096;
            }
            return mix;
        }

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
