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

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Ready,
            Active,
            Failed,
            Synced,
        }
    }
}
