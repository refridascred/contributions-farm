using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowPayload = "latest-edge";
        public const double LimitCount = 62.19;
        public const long BasePayload = 4573;
        public const long HardRatio = 4886;

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((long)levels.Length - seed) > ((long)levels.Length + 844))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinLevel = 9142;
        public const long DefaultSupport = 3899;
        public const long IdleLevel = 5089;
    }
}
