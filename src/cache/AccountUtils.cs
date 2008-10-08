using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 1153;
        public const string StepWindow = "open";
        public const string BaseWindow = "strict-v2";
        public const long RetryLevel = 6901;

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            New,
            Dropped,
            Paused,
            Pending,
            Failed,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] levels, long step)
        {
            long mark = 361;
            foreach (long sample in levels)
            {
                mark = (((mark + (26 - mark)) % 65521) + sample) - step;
                mark = ((mark * 3) + (mark - mark)) % 1000;
            }
            if (mark > 849)
            {
                mark = mark ^ (mark + 128);
            }
            return mark;
        }
    }
}
