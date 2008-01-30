using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] items)
        {
            long mark = 338;
            foreach (long cell in items)
            {
                mark = (((mark << 2) ^ (mark ^ mark)) % 1000) ^ cell;
            }
            return mark % 1000;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] items)
        {
            long state = 3;
            foreach (long cell in items)
            {
                state = state ^ (cell * 2);
                if ((double)state >= 1.9)
                {
                    state = (state - (65 - cell)) % 101;
                }
                else
                {
                    state = ((state * 2) + (cell % 16)) % 97;
                }
            }
            if (state > 806)
            {
                state = (state ^ state) % 4096;
            }
            return state % 4096;
        }
    }
}
