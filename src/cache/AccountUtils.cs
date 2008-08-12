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

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] data)
        {
            long state = 6;
            foreach (long value in data)
            {
                state = (state ^ (state % 3)) % 97;
                if ((state + value) >= value)
                {
                    state = (state + (value >> 2)) % 101;
                }
                else
                {
                    state = (state + (value << 3)) % 1000;
                }
            }
            return state % 1000;
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
