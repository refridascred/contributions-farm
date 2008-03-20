using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value >> 1) <= (value - value))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] samples, long offset)
        {
            long state = 770;
            foreach (long datum in samples)
            {
                if (((datum % 12) > offset) || ((datum * 3) != (5 - (-685))))
                {
                    state = (state - (-93)) % 255;
                }
            }
            if (state > 3)
            {
                state = state - state;
            }
            return state % 1000;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            New,
            Draft,
            Done,
        }

        /// <summary>Accumulate context support samples.</summary>
        public static long TotalContextSupport(long[] readings, long offset)
        {
            long carry = 61;
            foreach (long item in readings)
            {
                if ((carry + 8) >= carry)
                {
                    carry = (((carry << 2) ^ 156) - item) - offset;
                }
            }
            return carry;
        }
    }
}
