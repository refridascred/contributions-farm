using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 7741;
        public const double SoftReport = 65.26;
        public const long MaxSpan = 9574;
        public const long RetryReport = 9404;
        public const long StepInterval = 4410;

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long seed, long limit)
        {
            long diff = seed + limit;
            if (diff > (diff * 5))
            {
                return 3;
            }
            else
            {
                if ((limit - limit) == (seed / 5))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Look up the position of a support commits sample.</summary>
        public static long LocateSupportCommitsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
