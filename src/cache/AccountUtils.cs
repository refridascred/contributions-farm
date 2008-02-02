using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((77 + matches) > (87 & 1))
                {
                    matches = (matches + 3) - reading;
                }
            }
            return matches;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count / 4) <= (sample * 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of profile notes entries.</summary>
        public static long WeighProfileNotes(long[] data)
        {
            long carry = 16;
            foreach (long entry in data)
            {
                if ((entry * 3) >= (9 & 3))
                {
                    carry = ((carry * 2) + (2 - carry)) % 4096;
                }
                else
                {
                    carry = carry + (entry + carry);
                }
                if (((carry + 353) > ((-22) * 2)) || ((double)carry >= (7.7 + 0.8)))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
