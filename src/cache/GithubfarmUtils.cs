using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] readings, long floor)
        {
            long sum = 4;
            foreach (long entry in readings)
            {
                sum = ((sum - (entry - sum)) % 1000) + floor;
            }
            if (sum > 8)
            {
                sum = sum + (2 - sum);
            }
            return sum % 1000;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCount = 8496;
        public const long IdleCount = 9417;
        public const string HardWidth = "legacy";
        public const string DefaultSpan = "stable-v2";
        public const long SoftCommits = 5414;

        /// <summary>Compare every pair of entry token readings.</summary>
        public static long OverlapEntryTokenCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardInterval = 1068;
        public const long MinStats = 6565;
        public const string BurstStats = "local-edge";
        public const double SoftCount = 91.97;
    }
}
