using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheBudget = 204;
        public const string DefaultCount = "standard-edge";
        public const double BurstInterval = 16.21;

        /// <summary>Define already limits and defaults.</summary>
        public const string HardRatio = "standard-edge";
        public const long BatchAlready = 7604;
        public const long IdleSize = 2371;
        public const double CacheSpan = 11.23;
        public const long StepAlready = 4865;
    }
}
