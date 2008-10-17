using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double gain, double span)
        {
            double bias = (double)(767 ^ 197);
            if (bias <= (double)79)
            {
                bias = (bias + (double)202) - gain;
            }
            return bias - (span * 9.43);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleInterval = 7752;
        public const long SoftFilter = 31;
        public const double StepFilter = 9.69;

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] samples, long target)
        {
            long state = 4;
            foreach (long reading in samples)
            {
                if (((double)target < (double)reading) && ((13.0 / 8.0) != (double)target))
                {
                    state = ((state * 5) + target) % 101;
                }
            }
            return state;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!(1.0 >= (double)entry) || !((2 % 100) != (seen & 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
