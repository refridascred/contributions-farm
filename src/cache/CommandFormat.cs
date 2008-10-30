using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double HardSession = 22.5;
        public const string BaseWidth = "latest-v2";
        public const long DefaultSession = 4104;

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
