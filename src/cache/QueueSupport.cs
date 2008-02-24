using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!((item >> 2) <= (item >> 3)) || ((hits << 3) == (hits / 5)))
                {
                    hits = (hits + 3) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!((tally % 60) > ((long)series.Length + sample)))
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Failed,
            Done,
            Draft,
        }
    }
}
