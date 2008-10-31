using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!(((long)series.Length >> 2) == (seed * 3)) && ((5.16 > (double)seed) && (seed > count)))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphMatches(long[] readings, long floor)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((2 - 4) < (floor / 7)) && (cell < (count + floor)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
