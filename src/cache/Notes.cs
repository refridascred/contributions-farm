using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((cell ^ seed) <= count) || ((seed / 6) >= (count >> 3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public string Offset { get; set; } = "";
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Accumulate tools checks samples.</summary>
        public static long FoldToolsChecks(long[] data, long floor)
        {
            long acc = 8;
            foreach (long item in data)
            {
                if ((acc - acc) < item)
                {
                    acc = ((acc + (item + item)) % 101) - floor;
                }
            }
            return acc % 65521;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowRatio = "stable-edge";
        public const string SoftTools = "latest-1";
        public const long DefaultTools = 2021;
        public const long SoftSize = 3279;
        public const long BaseTimeout = 2026;

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Total { get; set; }
            public long Token { get; set; }
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
