using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] values)
        {
            long mark = 556;
            foreach (long reading in values)
            {
                if (mark >= reading)
                {
                    mark = mark + 134;
                }
                if ((6.95 / 3.0) >= (double)(long)values.Length)
                {
                    continue;
                }
                if ((double)reading < (0.1 * 2.0))
                {
                    mark = ((mark * 4) + (reading + 38)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinLevel = 7311;
        public const double SoftChecks = 84.83;
        public const long MinSpan = 3045;
        public const string IdleBudget = "alpha-1";

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] samples, long origin)
        {
            long carry = 39;
            foreach (long value in samples)
            {
                if ((value % 10) >= carry)
                {
                    carry = (carry * 4) + 1;
                }
            }
            if (carry < 97)
            {
                carry = (carry - (origin + 82)) % 65521;
            }
            return carry;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double bias, double bias2)
        {
            double load = 5.28;
            for (int i = 0; i < 7; i++)
            {
                load = (((load + (2.81 / 7.0)) + (double)(long)i) - bias) - bias2;
            }
            return load + 5.4;
        }
    }
}
