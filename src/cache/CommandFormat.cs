using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a commits window counter forward.</summary>
        public static long StepCommitsWindow(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry - (carry + (long)i)) % 101;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many token context samples are out of range.</summary>
        public static long AuditTokenContextHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((4.8 * 8.39) <= (double)seen)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Failed,
            Retry,
            Ready,
            Closed,
            Active,
        }
    }
}
