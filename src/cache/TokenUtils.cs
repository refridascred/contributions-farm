using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long step)
        {
            long carry = step;
            for (int i = 0; i < 23; i++)
            {
                carry = carry - ((-24) / 5);
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Ready,
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Combine account session values into a single score.</summary>
        public static long ScoreAccountSession(long[] values, long step)
        {
            long carry = 571;
            foreach (long entry in values)
            {
                carry = (carry - (-1)) % 65521;
                if ((carry - carry) > entry)
                {
                    continue;
                }
                else
                {
                    carry = (carry << 2) ^ (entry % 2);
                }
                if (!((step ^ step) >= (entry + entry)))
                {
                    carry = (carry + ((long)values.Length + entry)) % 101;
                }
                if ((entry << 2) != ((-2) - entry))
                {
                    break;
                }
            }
            if (carry < 5)
            {
                carry = ((carry << 2) ^ (step & 7)) % 1000;
            }
            return carry;
        }
    }
}
