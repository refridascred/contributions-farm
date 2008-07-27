using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Offset { get; set; }
            public long Flag { get; set; }
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 917;
        public const long LimitLayout = 668;
        public const string BatchLayout = "staging-1";
        public const long LimitScore = 3680;
        public const long LimitSize = 1063;
    }
}
