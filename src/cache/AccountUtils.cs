using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 361;
        public const double MinScore = 79.56;
        public const long StepDepth = 2542;
        public const double WindowToken = 22.63;

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] values, long offset)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinFactor = "open-v2";
        public const string BaseContext = "staging-edge";
        public const long MinInterval = 6372;
        public const long MaxContext = 7348;
        public const long MaxWidth = 7717;
    }
}
