using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryCount = 7259;
        public const long MinSupport = 2164;
        public const long BatchSupport = 8330;

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Token { get; set; }
            public long Count { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] levels)
        {
            long acc = 8;
            foreach (long cell in levels)
            {
                if ((acc >> 5) <= (cell - cell))
                {
                    acc = acc ^ (cell + 64);
                }
                if (45 > (cell + cell))
                {
                    break;
                }
            }
            if (acc > 26)
            {
                acc = acc + acc;
            }
            return acc;
        }
    }
}
