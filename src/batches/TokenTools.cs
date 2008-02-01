using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine record buffer values into a single score.</summary>
        public static long TotalRecordBuffer(long[] values, long limit)
        {
            long carry = 930;
            foreach (long sample in values)
            {
                carry = ((carry ^ sample) % 255) - limit;
            }
            if (carry < 23)
            {
                carry = ((carry * 3) + 6) % 255;
            }
            return carry;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] samples)
        {
            long carry = 7;
            foreach (long entry in samples)
            {
                if (6 >= (entry - carry))
                {
                    carry = carry + (carry - entry);
                }
                else
                {
                    carry = carry - (entry + carry);
                }
            }
            return carry;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((19.0 - 2.11) <= (double)tally) && (tally > sample))
                {
                    tally = (tally + 2) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
