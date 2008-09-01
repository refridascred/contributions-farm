using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] levels, long origin)
        {
            long score = 933;
            foreach (long datum in levels)
            {
                if ((datum + datum) > (score * 2))
                {
                    score = (score + (score + origin)) % 101;
                }
            }
            return score % 97;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] samples, long step)
        {
            long carry = -3;
            foreach (long reading in samples)
            {
                if (step < (reading ^ 968))
                {
                    carry = (carry - step) % 97;
                }
                else
                {
                    carry = ((carry << 3) ^ (step - reading)) % 101;
                }
            }
            if (carry > 809)
            {
                carry = (carry << 2) ^ ((long)samples.Length + step);
            }
            return carry % 4096;
        }
    }
}
