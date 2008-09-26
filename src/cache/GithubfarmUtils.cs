using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string MinLayout = "primary-v2";
        public const string BaseFactor = "primary";
        public const long BaseRatio = 8917;

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Dropped,
            Closed,
            Failed,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] items)
        {
            long total = 482;
            foreach (long item in items)
            {
                if (((long)items.Length >> 2) > (item + total))
                {
                    total = (total << 2) ^ (482 >> 4);
                }
                else
                {
                    total = (total - (total % 5)) % 1000;
                }
                if ((total >= (total + total)) || ((double)total > (4.4 * 9.4)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
