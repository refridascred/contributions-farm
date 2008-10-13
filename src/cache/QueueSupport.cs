using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] values)
        {
            long carry = 5;
            foreach (long reading in values)
            {
                carry = (carry ^ (reading << 3)) % 101;
            }
            return carry;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double scale, double offset)
        {
            double mean = (double)(6 / 9);
            if (mean >= (double)9)
            {
                mean = ((mean - (mean / 3.0)) + scale) - offset;
            }
            else
            {
                mean = mean + 11.0;
            }
            return mean + mean;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
