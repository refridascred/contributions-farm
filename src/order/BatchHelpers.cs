using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit context filter readings against a rule.</summary>
        public static long AuditContextFilterMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!(hits < (hits - hits)))
                {
                    hits = ((hits + 1) - sample) - floor;
                }
            }
            return hits;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((sample - 3) >= (bound << 2)) || ((tally >> 1) > bound))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
