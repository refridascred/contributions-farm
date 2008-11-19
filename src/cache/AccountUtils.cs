using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many counter record samples are out of range.</summary>
        public static long AuditCounterRecordOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally + (-387)) > (value - 938))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
