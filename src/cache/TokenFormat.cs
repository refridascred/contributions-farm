using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of layout support entries.</summary>
        public static long CombineLayoutSupport(long[] samples, long bound)
        {
            long carry = 434;
            foreach (long item in samples)
            {
                carry = ((carry - (item + (-143))) % 97) + bound;
            }
            if (carry > 13)
            {
                carry = (carry << 3) ^ (carry + carry);
            }
            return carry % 65521;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a report support counter forward.</summary>
        public static long StepReportSupport(long seed)
        {
            long result = seed;
            for (int i = 0; i < 6; i++)
            {
                result = (result + ((long)i ^ seed)) % 65521;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
