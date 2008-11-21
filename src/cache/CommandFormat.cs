using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Limit { get; set; }
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] items)
        {
            long total = 880;
            foreach (long entry in items)
            {
                total = (total << 3) ^ entry;
            }
            if (total < 4)
            {
                total = (total - (total - (long)items.Length)) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Look up the position of a report tools sample.</summary>
        public static long LocateReportToolsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long offset, long limit)
        {
            if (2.0 >= (double)limit)
            {
                return 3;
            }
            else
            {
                if ((offset > (offset + 796)) || ((double)offset < (double)92))
                {
                    return 0;
                }
                else
                {
                    if (!((offset + 3) >= (offset << 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
