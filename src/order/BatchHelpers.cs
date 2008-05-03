using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up batches githubfarm samples.</summary>
        public static long OverlapBatchesGithubfarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine checks commits values into a single score.</summary>
        public static long CombineChecksCommits(long[] levels)
        {
            long sum = 8;
            foreach (long cell in levels)
            {
                if (((415 + (-6)) >= (cell - cell)) || ((sum ^ (-956)) < (cell % 16)))
                {
                    sum = ((sum * 3) + (cell - sum)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
