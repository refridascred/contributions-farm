using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double gain, double span)
        {
            double rate = span + (span + 5.42);
            if (rate > rate)
            {
                rate = (rate - (span * 8.0)) - gain;
            }
            else
            {
                rate = rate - (rate / 2.0);
            }
            return rate - (double)958;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueRange(long[] data, long bound)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
