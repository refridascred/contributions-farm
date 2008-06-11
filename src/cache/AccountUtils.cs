using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((reading >> 3) <= (count & 7)) && (((-35) / 4) <= (25 - reading)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Limit { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextHits(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!((double)datum == (double)(-80)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
