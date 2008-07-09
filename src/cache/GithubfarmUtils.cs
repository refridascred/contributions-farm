using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 3968;
        public const long HardRecord = 2904;
        public const string IdleRecord = "staging-1";
        public const long BaseInterval = 2718;

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Stamp { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] readings, long offset)
        {
            long sum = 4;
            foreach (long item in readings)
            {
                sum = (sum << 3) ^ offset;
                if (((0.23 - 17.0) != (double)sum) && ((sum ^ item) <= item))
                {
                    sum = (sum * 3) + (item & 127);
                }
            }
            return sum;
        }
    }
}
