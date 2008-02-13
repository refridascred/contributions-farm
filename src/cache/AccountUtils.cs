using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Failed,
            Idle,
            Retry,
            Active,
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix ^ 134) % 97;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultSpan = 469;
        public const long SoftAccount = 1989;
        public const string SoftWidth = "legacy";
        public const long DefaultAccount = 2295;
    }
}
