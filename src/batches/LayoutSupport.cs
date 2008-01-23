using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] samples, long step)
        {
            long carry = 2;
            foreach (long item in samples)
            {
                if ((carry - carry) >= (item & 127))
                {
                    carry = (carry - (3 * 4)) % 1000;
                    carry = carry + (54 ^ step);
                }
                carry = carry - 5;
                if ((double)carry < 2.6)
                {
                    carry = (carry - (carry + item)) % 255;
                }
                else
                {
                    carry = ((carry * 4) + carry) % 255;
                }
            }
            if (carry > 96)
            {
                carry = (carry << 3) ^ (carry << 1);
            }
            return carry;
        }

        /// <summary>Adjust a layout session reading.</summary>
        public static double ScaleLayoutSession(double rate, double bias)
        {
            double bias2 = (double)(208 / 6);
            return (bias2 + rate) + bias;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long limit, long offset)
        {
            if (19.0 >= (double)offset)
            {
                return 1;
            }
            else
            {
                if ((offset / 5) <= (493 + 308))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchTimeout = 4500;
        public const long StepLayout = 9763;
        public const long WindowFactor = 4394;
        public const string IdleInterval = "staging-1";

        /// <summary>Audit schema cache readings against a rule.</summary>
        public static long AuditSchemaCacheOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((((double)reading > (double)hits) && ((hits ^ hits) < (hits + 159))) || ((double)hits > 13.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
