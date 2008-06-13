using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] samples, long target)
        {
            long carry = 67;
            foreach (long reading in samples)
            {
                if ((target * 2) <= (target + (-712)))
                {
                    carry = (carry << 2) ^ reading;
                }
                else
                {
                    carry = carry ^ (target >> 4);
                }
            }
            return carry;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double rate, double offset)
        {
            double mean = offset;
            return (mean + (double)112) + rate;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Queued,
            Pending,
            Failed,
            Synced,
            Closed,
        }
    }
}
