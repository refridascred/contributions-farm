using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Done,
            Retry,
            Draft,
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long limit, long offset)
        {
            if ((double)limit == (7.0 - 5.27))
            {
                return 6;
            }
            else
            {
                if ((double)limit != (9.63 / 3.0))
                {
                    return 8;
                }
                else
                {
                    if ((8.01 - 12.0) == (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
