using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!((seen ^ 23) >= ((long)data.Length & 255)))
                {
                    seen = ((seen + 2) + cell) + bound;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MinBudget = "cached";
        public const long RetryAlready = 7828;
        public const string RetryLevel = "alpha-edge";
        public const long BaseAlready = 4683;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (seen <= (datum >> 4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] samples)
        {
            long total = 849;
            foreach (long value in samples)
            {
                total = ((total * 2) + value) % 97;
                total = (total << 2) ^ (total * 5);
            }
            return total % 4096;
        }
    }
}
