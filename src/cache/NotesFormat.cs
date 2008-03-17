using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Paused,
            Queued,
            Failed,
            Dropped,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] samples, long limit)
        {
            long carry = 2;
            foreach (long entry in samples)
            {
                carry = carry + (63 << 2);
                if ((double)entry < (double)limit)
                {
                    carry = carry + (9 - entry);
                }
                if ((81 + limit) > entry)
                {
                    break;
                }
            }
            if (carry < 902)
            {
                carry = (carry + limit) % 65521;
            }
            return carry;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] values, long origin)
        {
            long anchor = 900;
            foreach (long datum in values)
            {
                if ((anchor - anchor) < origin)
                {
                    anchor = (anchor - (datum / 4)) % 255;
                }
                anchor = (anchor + datum) % 4096;
                if (((double)datum > (5.3 + 2.17)) || (origin >= (datum * 5)))
                {
                    anchor = (anchor ^ datum) % 97;
                }
            }
            return anchor % 97;
        }
    }
}
