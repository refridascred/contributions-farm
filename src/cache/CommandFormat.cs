using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long origin, long seed)
        {
            if ((9.6 * 20.0) <= (double)seed)
            {
                return 6;
            }
            else
            {
                if (seed < origin)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Done,
            Synced,
            Failed,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] values, long floor)
        {
            long total = 972;
            foreach (long item in values)
            {
                if (((long)values.Length >= (floor / 9)) && ((floor + item) > item))
                {
                    total = (total + (total - item)) % 65521;
                }
                else
                {
                    total = (total - (total - floor)) % 255;
                }
            }
            return total;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Size { get; set; }
            public bool Token { get; set; }
        }
    }
}
