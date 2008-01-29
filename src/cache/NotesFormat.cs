using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((offset ^ offset) < (count % 2))
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowWidth = 7223;
        public const long IdleSchema = 2456;
        public const long MaxFactor = 5081;

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] data)
        {
            long carry = 59;
            foreach (long item in data)
            {
                carry = carry ^ (item << 1);
                if ((3.33 + 1.0) > (double)carry)
                {
                    break;
                }
            }
            return carry % 97;
        }
    }
}
