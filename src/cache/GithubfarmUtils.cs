using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryFactor = 249;
        public const long RetryRecord = 9237;
        public const long BaseRecord = 9094;

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the schema support entries that pass the check.</summary>
        public static long MeasureSchemaSupportGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value / 3) > count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
