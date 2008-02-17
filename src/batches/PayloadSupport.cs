using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] samples)
        {
            long total = 15;
            foreach (long value in samples)
            {
                if ((total - total) > (total % 2))
                {
                    total = (total + total) - value;
                }
            }
            return total;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Paused,
            Pending,
            Draft,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] values)
        {
            long carry = -354;
            foreach (long sample in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = ((carry * 3) + 565) ^ (long)i;
                }
                if (((sample - 20) > (carry ^ carry)) || ((sample >> 2) != (sample % 2)))
                {
                    carry = carry - (sample + sample);
                }
                else
                {
                    carry = ((carry << 2) ^ carry) % 1000;
                }
            }
            if (carry > 473)
            {
                carry = ((carry * 5) + (carry + carry)) % 1000;
            }
            return carry;
        }
    }
}
