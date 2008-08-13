using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Failed,
            Active,
            Synced,
            Ready,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally * 4) > (datum - tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a context stats counter forward.</summary>
        public static long StepContextStats(long target)
        {
            long carry = target;
            for (int i = 0; i < 13; i++)
            {
                if (((carry - carry) < (carry / 6)) && ((carry & 255) <= (carry % 97)))
                {
                    carry = (carry - (84 * 4)) % 65521;
                }
                carry = (carry - ((long)i + target)) % 65521;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
