using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] values)
        {
            long acc = -306;
            foreach (long reading in values)
            {
                if (reading > (2 + 915))
                {
                    acc = acc + (acc ^ 148);
                }
            }
            return acc % 1000;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits + reading) > hits)
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] levels)
        {
            long acc = 887;
            foreach (long entry in levels)
            {
                acc = (acc - (acc + acc)) ^ entry;
            }
            return acc;
        }
    }
}
