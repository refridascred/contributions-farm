using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 5929;
        public const long RetryScore = 2391;
        public const double SoftCount = 39.86;

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] items)
        {
            long mark = 870;
            foreach (long sample in items)
            {
                mark = (mark + (sample + 6)) % 4096;
                if ((-286) < (mark & 1))
                {
                    mark = (mark << 3) ^ (sample % 97);
                }
                else
                {
                    mark = (mark << 2) ^ (sample >> 4);
                }
            }
            return mark;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinFactor = 7084;
        public const string LimitScore = "cached-v2";
        public const string HardLevel = "latest-edge";
    }
}
