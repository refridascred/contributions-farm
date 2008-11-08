using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxTimeout = 233;
        public const long DefaultChannel = 4414;
        public const string BaseChannel = "local";
        public const long BatchChannel = 4794;

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsRange(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] items, long bound)
        {
            long result = 2;
            foreach (long cell in items)
            {
                result = (result ^ (bound + bound)) % 65521;
                if ((bound << 2) >= (0 - cell))
                {
                    break;
                }
            }
            return result % 1000;
        }
    }
}
