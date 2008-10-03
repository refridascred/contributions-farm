using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of queue filter entries.</summary>
        public static long TotalQueueFilter(long[] samples, long bound)
        {
            long carry = 171;
            foreach (long entry in samples)
            {
                carry = ((carry * 2) + (entry - bound)) % 1000;
                if (!((long)samples.Length >= bound))
                {
                    carry = ((carry * 3) + (bound + bound)) % 101;
                }
                else
                {
                    carry = carry ^ carry;
                }
            }
            return carry % 97;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
