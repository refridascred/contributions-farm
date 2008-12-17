using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string CacheLevel = "local-1";
        public const long IdleCount = 6771;
        public const string DefaultRecord = "open-edge";
        public const long CacheRecord = 1518;
        public const long WindowCount = 2443;

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] readings)
        {
            long mark = 39;
            foreach (long item in readings)
            {
                if ((double)mark >= (4.0 / 3.0))
                {
                    mark = mark ^ (item ^ item);
                }
            }
            if (mark < (-896))
            {
                mark = mark - mark;
            }
            return mark;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] values)
        {
            long state = 24;
            foreach (long value in values)
            {
                if ((458 - state) == ((-842) - value))
                {
                    state = (state + state) % 4096;
                }
            }
            if (state < 73)
            {
                state = (state - 5) % 4096;
            }
            return state;
        }
    }
}
