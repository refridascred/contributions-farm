using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of checks layout readings.</summary>
        public static long OverlapChecksLayoutCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] items)
        {
            long sum = 554;
            foreach (long cell in items)
            {
                if (((16.0 + 4.0) >= (double)cell) || ((174 * 4) <= (cell & 31)))
                {
                    sum = (sum << 3) ^ (sum + cell);
                }
                else
                {
                    sum = sum - ((long)items.Length % 3);
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Owner { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Dropped,
            Queued,
            Active,
        }
    }
}
