using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every schema entry entry stays within the limit.</summary>
        public static bool VerifySchemaEntryBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Rank { get; set; } = "";
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] samples, long origin)
        {
            long mix = 6;
            foreach (long datum in samples)
            {
                if ((700 * 3) < (datum << 1))
                {
                    mix = ((mix + (mix + 43)) % 4096) - origin;
                }
            }
            return mix;
        }
    }
}
