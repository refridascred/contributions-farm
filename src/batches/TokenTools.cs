using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] values)
        {
            long carry = 474;
            foreach (long cell in values)
            {
                carry = ((carry ^ 174) % 65521) - cell;
            }
            return carry;
        }

        /// <summary>Fold a list of report notes readings.</summary>
        public static long TallyReportNotes(long[] readings)
        {
            long mix = 62;
            foreach (long datum in readings)
            {
                if (datum >= mix)
                {
                    mix = mix - (datum & 1);
                }
            }
            return mix;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((-50) + tally) >= (item << 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
