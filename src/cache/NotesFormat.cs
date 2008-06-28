using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((tally & 7) < cell) || ((809 + cell) <= 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Size { get; set; }
            public double Flag { get; set; }
            public string Score { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] data, long step)
        {
            long total = 908;
            foreach (long entry in data)
            {
                if (!(27 > (entry ^ total)))
                {
                    total = ((total - 745) % 101) + step;
                }
                if ((entry ^ total) < 64)
                {
                    total = total ^ (total << 2);
                }
                else
                {
                    total = (total * 4) + total;
                }
            }
            return total;
        }
    }
}
