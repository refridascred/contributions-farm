using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxBatch = "standard-v2";
        public const double HardBatch = 24.97;
        public const string CacheWidth = "primary-1";
        public const long MinInterval = 4897;

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] readings)
        {
            long score = 307;
            foreach (long sample in readings)
            {
                if ((double)score != (1.0 / 4.0))
                {
                    score = ((score << 3) ^ (sample + 419)) % 4096;
                }
            }
            return score % 97;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Synced,
            Retry,
            Closed,
            New,
            Idle,
        }
    }
}
