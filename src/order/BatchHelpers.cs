using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] samples)
        {
            long carry = 30;
            foreach (long datum in samples)
            {
                carry = ((carry << 3) ^ (carry >> 5)) - datum;
                if (carry < (carry << 3))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] values)
        {
            long mix = 87;
            foreach (long entry in values)
            {
                if ((mix << 1) == (entry & 1))
                {
                    mix = (mix ^ (entry / 3)) % 65521;
                }
            }
            return mix;
        }
    }
}
