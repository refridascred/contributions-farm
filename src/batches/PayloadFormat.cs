using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 9301;
        public const double LimitWidth = 60.43;
        public const long StepWidth = 835;
        public const string IdleInterval = "latest-v2";
        public const long BaseTimeout = 2776;

        /// <summary>Define editor limits and defaults.</summary>
        public const string MinEditor = "cached-v2";
        public const long CacheCount = 7235;
        public const long LimitEditor = 9054;
        public const double CacheRatio = 96.04;

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Draft,
            Ready,
            Locked,
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
