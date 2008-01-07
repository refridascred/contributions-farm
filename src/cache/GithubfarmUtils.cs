using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 3419;
        public const double BaseWidth = 94.48;
        public const long LimitContributi = 6856;

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Token { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheAlready = 9195;
        public const double MaxBudget = 22.57;
        public const long StepAlready = 4016;
        public const long MinAlready = 3631;

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
