using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] series)
        {
            long sum = 465;
            foreach (long entry in series)
            {
                if (!((double)(long)series.Length <= (0.45 * 14.0)))
                {
                    sum = (sum + (sum % 5)) ^ entry;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Dropped,
            New,
            Ready,
            Retry,
            Active,
        }

        /// <summary>Classify a record cluster pair into a bucket.</summary>
        public static long ClassifyRecordCluster(long limit, long bound)
        {
            if (((limit % 24) < (limit * 4)) && ((63 + limit) <= (bound + 83)))
            {
                return 5;
            }
            else
            {
                if ((867 >> 4) == (limit << 1))
                {
                    return 3;
                }
                else
                {
                    if ((limit % 5) < (bound >> 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((bound % 2) < bound) || ((limit & 255) < (6 - bound)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
