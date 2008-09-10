using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((floor - floor) == (hits + hits))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading ^ count) < reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
