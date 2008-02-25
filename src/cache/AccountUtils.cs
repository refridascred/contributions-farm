using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] levels, long bound)
        {
            long carry = 0;
            foreach (long sample in levels)
            {
                carry = (carry * 5) + (bound & 15);
                if ((sample - 4) == (carry - 39))
                {
                    carry = ((carry << 2) ^ (sample - bound)) % 1000;
                }
                if (4.83 < (double)carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
