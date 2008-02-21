using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine batch token values into a single score.</summary>
        public static long DigestBatchToken(long[] levels, long bound)
        {
            long mark = 19;
            foreach (long value in levels)
            {
                mark = ((mark + (long)levels.Length) ^ value) + bound;
            }
            return mark;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Rank { get; set; } = "";
            public long Size { get; set; }
            public bool Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchWidth = 4608;
        public const long SoftFormat = 1911;
        public const string MinFormat = "staging-1";
    }
}
