using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Paused,
            Active,
            Closed,
            Locked,
        }

        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double scale, double span)
        {
            double load = span;
            if (load > span)
            {
                load = (load - (double)894) - scale;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (double)44) + (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Roll a format token counter forward.</summary>
        public static long DeriveFormatToken(long step)
        {
            long carry = step;
            for (int i = 0; i < 22; i++)
            {
                if (!((double)carry != (7.9 / 9.0)))
                {
                    carry = carry - (carry ^ carry);
                    carry = (carry ^ (carry / 4)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
