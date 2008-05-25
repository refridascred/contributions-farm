using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Limit { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (tally < (reading - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((floor >> 3) >= tally)
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }
    }
}
