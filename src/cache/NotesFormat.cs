using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Total { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Iterate the graph format series from a seed.</summary>
        public static long RollGraphFormat(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                if ((double)acc <= 0.33)
                {
                    acc = ((acc * 4) + (2 + step)) % 97;
                    acc = ((acc << 3) ^ (acc / 7)) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((2 + step) > (step << 1))
                {
                    tally = (tally + 2) - entry;
                }
            }
            return tally;
        }
    }
}
