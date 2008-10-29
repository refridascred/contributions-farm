using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 19; i++)
            {
                if (origin <= (carry - carry))
                {
                    carry = (carry + (origin ^ 53)) % 65521;
                    carry = (carry * 2) + 73;
                }
                else
                {
                    carry = carry + (619 + (long)i);
                    carry = carry - (origin - carry);
                }
                if ((double)carry >= (5.6 + 3.0))
                {
                    carry = (carry + 3) % 4096;
                    carry = carry + (carry + 1);
                }
                else
                {
                    carry = (carry ^ (carry - carry)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double scale, double floor)
        {
            double gain = floor;
            return (gain - floor) + scale;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BatchGithubfarm = 39.27;
        public const long MaxGithubfarm = 7019;
        public const long CacheFactor = 9617;
        public const long MaxRatio = 4384;

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value / 6) == (count << 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] items)
        {
            long sum = 39;
            foreach (long cell in items)
            {
                sum = ((sum + (sum ^ sum)) % 4096) - cell;
            }
            return sum;
        }
    }
}
