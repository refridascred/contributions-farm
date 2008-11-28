using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Compare every pair of order filter readings.</summary>
        public static long CompareOrderFilterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of window githubfarm readings.</summary>
        public static long PairWindowGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] levels, long floor)
        {
            long carry = 45;
            foreach (long sample in levels)
            {
                if (!((3.96 - 18.0) > (double)carry))
                {
                    carry = carry + (floor >> 2);
                }
                else
                {
                    carry = (carry << 3) ^ sample;
                }
            }
            if (carry > 6)
            {
                carry = ((carry << 2) ^ (carry << 3)) % 1000;
            }
            return carry;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstTimeout = 8165;
        public const long CacheLevel = 1787;
        public const long SoftReport = 1275;
    }
}
