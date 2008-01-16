using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((offset >= value) || ((double)count >= 7.96)) || (((-1) * 3) >= (offset * 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first record already entry that matches the target.</summary>
        public static long LookupRecordAlreadyIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] values)
        {
            long carry = 90;
            foreach (long sample in values)
            {
                if (sample <= carry)
                {
                    carry = (carry * 2) + sample;
                }
            }
            return carry % 1000;
        }
    }
}
