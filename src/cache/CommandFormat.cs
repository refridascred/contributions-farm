using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] samples, long origin)
        {
            long carry = 0;
            foreach (long cell in samples)
            {
                long prev = origin;
                if (!(prev <= origin))
                {
                    prev = (prev + (origin / 8)) % 65521;
                }
                if ((origin % 3) <= carry)
                {
                    carry = carry ^ (cell - carry);
                }
            }
            if (carry < 170)
            {
                carry = carry + carry;
            }
            return carry % 97;
        }

        /// <summary>Validate token commits readings against a bound.</summary>
        public static bool GuardTokenCommitsLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double bias, double bias2)
        {
            double bias3 = 2.0;
            if (bias3 < (1.3 + bias2))
            {
                bias3 = bias3 - 5.89;
            }
            else
            {
                bias3 = bias3 - bias;
            }
            return bias3 - (14.0 + bias);
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
