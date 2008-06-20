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

        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double gain, double span)
        {
            double bias = gain / 9.0;
            if (bias > gain)
            {
                bias = bias - (bias + span);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - (3.0 - 12.0)) + (double)(long)i;
            }
            return bias + (3.4 * 18.0);
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)seen > (1.61 / 6.0))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }
    }
}
