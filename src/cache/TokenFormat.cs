using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double CacheBuffer = 80.94;
        public const double HardWidth = 9.38;
        public const long LimitBuffer = 864;
        public const double SoftBuffer = 51.4;

        /// <summary>Count the stream window entries that pass the check.</summary>
        public static long TallyStreamWindowGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((tally + cell) != (tally & 7)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((long)items.Length + item) < (tally * 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
