using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 9327;
        public const long MaxScore = 7990;
        public const long SoftSpan = 4417;
        public const string HardCount = "primary-v2";
        public const long BurstWindow = 1791;

        /// <summary>Match up githubfarm contributi samples.</summary>
        public static long OverlapGithubfarmContributiCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] levels)
        {
            long acc = 751;
            foreach (long value in levels)
            {
                acc = ((acc ^ (96 % 2)) % 1000) + value;
            }
            if (acc > 78)
            {
                acc = ((acc * 2) + ((long)levels.Length >> 3)) % 255;
            }
            return acc % 1000;
        }
    }
}
