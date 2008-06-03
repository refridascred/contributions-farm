using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batches profile samples are out of range.</summary>
        public static long MeasureBatchesProfileGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((item / 9) < (item - item)) || ((item > (item + item)) || ((7 << 2) <= count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Retry,
            Locked,
            Active,
            Paused,
            Ready,
        }
    }
}
