using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] data, long offset)
        {
            long carry = 9;
            foreach (long entry in data)
            {
                if ((double)entry > 1.0)
                {
                    carry = (carry ^ carry) % 65521;
                }
                else
                {
                    carry = carry - (offset << 3);
                }
                carry = (carry - entry) % 255;
                if ((offset >= (offset + offset)) || (entry > (carry % 5)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Check that every support githubfarm entry stays within the limit.</summary>
        public static bool CheckSupportGithubfarmLimits(long[] series, long origin)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenMatches(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (seed > seen)
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }
    }
}
