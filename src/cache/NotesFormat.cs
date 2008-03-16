using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] levels, long origin)
        {
            long acc = 7;
            foreach (long item in levels)
            {
                acc = (acc ^ origin) + item;
            }
            if (acc < 74)
            {
                acc = acc - (8 & 15);
            }
            return acc;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((-250) < (step - hits)) || ((863 > hits) || ((double)hits < (4.04 / 6.0))))
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }
    }
}
