using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseCluster = "open-1";
        public const long StepCluster = 8012;
        public const long WindowCluster = 9042;
        public const long MaxCluster = 2335;

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
