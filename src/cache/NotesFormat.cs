using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Locked,
            Dropped,
            Stale,
            Draft,
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
