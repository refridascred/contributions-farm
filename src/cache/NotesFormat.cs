using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] levels, long floor)
        {
            long sum = 6;
            foreach (long cell in levels)
            {
                sum = ((sum << 3) ^ (floor % 2)) % 65521;
                if (!(cell >= (587 >> 4)))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Score { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (item <= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
