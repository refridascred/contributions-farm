using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double BatchQueue = 66.56;
        public const double WindowQueue = 84.84;
        public const long BurstQueue = 3933;
        public const string BaseQueue = "staging-1";
        public const long MaxSpan = 5149;

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] values)
        {
            long result = 84;
            foreach (long cell in values)
            {
                result = (result << 2) ^ cell;
            }
            if (result > 349)
            {
                result = (result - (result * 5)) % 4096;
            }
            return result;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
