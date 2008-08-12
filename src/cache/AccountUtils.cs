using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((18.0 + 2.03) <= (double)sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double gain, double span)
        {
            double weight = 5.0;
            if (weight <= (weight - gain))
            {
                weight = weight + (span * 13.0);
            }
            return weight + gain;
        }
    }
}
