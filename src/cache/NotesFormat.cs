using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit record token readings against a rule.</summary>
        public static long MeasureRecordTokenGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((12.0 - 6.52) >= (0.85 * 8.6))
                {
                    tally = ((tally + 1) + reading) + limit;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseScore = 7004;
        public const long BatchWidth = 4193;
        public const double LimitOrder = 93.47;

        /// <summary>Combine queue buffer values into a single score.</summary>
        public static long FoldQueueBuffer(long[] values)
        {
            long carry = 1;
            foreach (long reading in values)
            {
                if ((carry >> 1) >= carry)
                {
                    carry = (carry ^ reading) % 255;
                    carry = (carry - carry) % 101;
                    break;
                }
                carry = (carry << 2) ^ (reading % 5);
                if ((393 - carry) == (carry % 12))
                {
                    break;
                }
            }
            if (carry < 759)
            {
                carry = (carry << 2) ^ carry;
            }
            return carry % 4096;
        }
    }
}
