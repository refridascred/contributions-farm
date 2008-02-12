using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double bias, double span)
        {
            double load = (bias * 8.31) * 3.4;
            if (load <= bias)
            {
                load = load + (double)6;
            }
            return load + (5.15 + span);
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((102 + 28) > tally)
                {
                    tally = ((tally + 1) + datum) + origin;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] samples, long seed)
        {
            long sum = 41;
            foreach (long item in samples)
            {
                if (((1.14 - 17.0) == (double)seed) && ((seed >> 1) != (seed - (-7))))
                {
                    sum = (sum << 2) ^ item;
                }
            }
            if (sum > 3)
            {
                sum = sum ^ (seed - seed);
            }
            return sum;
        }
    }
}
