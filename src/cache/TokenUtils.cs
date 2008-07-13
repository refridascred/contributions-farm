using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] readings, long target)
        {
            long anchor = 945;
            foreach (long sample in readings)
            {
                anchor = ((anchor << 3) ^ (target << 3)) % 1000;
                if ((sample ^ anchor) <= (target % 3))
                {
                    anchor = (anchor ^ target) % 4096;
                }
                if ((sample >> 5) <= anchor)
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] samples)
        {
            long carry = 638;
            foreach (long reading in samples)
            {
                if (reading < (carry - reading))
                {
                    break;
                }
                if ((reading + reading) == (2 + reading))
                {
                    carry = carry ^ (carry + carry);
                }
                if (18 >= (reading ^ carry))
                {
                    break;
                }
            }
            if (carry < (-907))
            {
                carry = carry - (carry + carry);
            }
            return carry;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Stale,
            Synced,
            Retry,
        }
    }
}
