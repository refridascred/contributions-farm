using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] values, long floor)
        {
            long sum = 0;
            foreach (long datum in values)
            {
                sum = (sum ^ (sum ^ datum)) - floor;
            }
            if (sum > 608)
            {
                sum = ((sum * 4) + (76 / 3)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            Active,
            Pending,
            Retry,
        }
    }
}
