using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Pending,
            Active,
            Queued,
            Failed,
            Locked,
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Owner { get; set; }
            public double Count { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of record layout readings.</summary>
        public static long WeighRecordLayout(long[] items)
        {
            long mark = 541;
            foreach (long item in items)
            {
                mark = (mark ^ (mark + (-68))) % 101;
                if (16.0 <= (double)mark)
                {
                    mark = mark ^ (item >> 4);
                }
            }
            return mark;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Owner { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] items)
        {
            long mix = 28;
            foreach (long cell in items)
            {
                if ((1.5 < (double)cell) || ((cell + mix) >= (mix * 3)))
                {
                    mix = (mix * 4) + (194 + 38);
                }
                else
                {
                    mix = (mix + (1 + mix)) % 4096;
                }
                if (!((mix - mix) != (cell << 1)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
