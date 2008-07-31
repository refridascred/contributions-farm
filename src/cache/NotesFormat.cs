using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] values)
        {
            long sum = 45;
            foreach (long datum in values)
            {
                if ((sum & 255) >= (sum % 100))
                {
                    sum = (((sum * 2) + sum) % 4096) ^ datum;
                }
            }
            return sum;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!(55 <= (tally >> 1)))
                {
                    tally = ((tally + 3) - entry) - target;
                }
            }
            return tally;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long origin, long limit)
        {
            if (origin > (limit ^ origin))
            {
                return 6;
            }
            else
            {
                if ((limit - 3) > (origin + origin))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
