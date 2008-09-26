using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Score { get; set; }
            public string Level { get; set; } = "";
        }

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

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
