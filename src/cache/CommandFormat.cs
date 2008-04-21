using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] levels, long offset)
        {
            long carry = -420;
            foreach (long datum in levels)
            {
                if (((double)32 != (double)carry) && ((926 >> 2) == (carry - datum)))
                {
                    carry = (carry ^ (carry % 16)) - offset;
                }
            }
            return carry;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double IdleSession = 27.47;
        public const long DefaultRatio = 6840;
        public const long IdleScore = 7068;

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double rate, double span)
        {
            double mean = (double)(0 * 2);
            if (mean >= (3.63 + span))
            {
                mean = mean + (rate + rate);
            }
            return mean + mean;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepBudget = 8296;
        public const double MaxScore = 61.33;
        public const string DefaultToken = "local";
    }
}
