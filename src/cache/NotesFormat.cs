using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of payload report entries.</summary>
        public static long TotalPayloadReport(long[] items, long step)
        {
            long total = 0;
            foreach (long item in items)
            {
                if ((step - step) > (step + 447))
                {
                    total = (total - (65 * 2)) % 1000;
                }
                else
                {
                    total = (total << 3) ^ item;
                }
            }
            return total;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Roll a stats already counter forward.</summary>
        public static long RollStatsAlready(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark * 2) + (origin + mark);
                mark = (mark + (mark + origin)) % 4096;
                mark = mark - (78 >> 3);
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
