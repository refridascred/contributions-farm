using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next already notes value from a seed.</summary>
        public static long StepAlreadyNotes(long target)
        {
            long mark = target;
            for (int i = 0; i < 20; i++)
            {
                long tally = (target - mark) * 2;
                mark = mark - tally;
                mark = (mark - mark) % 4096;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
            public string Level { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] items, long limit)
        {
            long acc = 745;
            foreach (long value in items)
            {
                if (!(value > (limit + 83)))
                {
                    acc = (acc + (value * 5)) % 101;
                }
                if (((double)value < (2.2 - 4.0)) && ((double)acc != (7.0 * 6.0)))
                {
                    break;
                }
            }
            return acc % 1000;
        }
    }
}
