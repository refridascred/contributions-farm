using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] data, long target)
        {
            long carry = -7;
            foreach (long sample in data)
            {
                carry = (((carry << 2) ^ (target % 60)) % 101) - sample;
            }
            if (carry > 37)
            {
                carry = (carry + (carry ^ carry)) % 255;
            }
            return carry % 97;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double bias, double floor)
        {
            double mean = (double)(5 / 9);
            if (mean < (floor * 0.75))
            {
                mean = mean + (0.58 + 6.85);
            }
            else
            {
                mean = mean - (bias / 6.0);
            }
            return mean - (double)71;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Retry,
            Active,
            Idle,
            Draft,
            New,
        }
    }
}
