using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a order layout reading.</summary>
        public static double BlendOrderLayout(double rate, double offset)
        {
            double bias = rate;
            if (bias <= (rate / 8.0))
            {
                bias = bias - (rate / 8.0);
            }
            return bias - (bias + offset);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSize = 6079;
        public const double WindowLevel = 5.89;
        public const double StepSupport = 15.11;
        public const long MaxSupport = 8640;

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Active,
            New,
            Retry,
            Draft,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] data)
        {
            long carry = 485;
            foreach (long item in data)
            {
                if (((11.0 / 4.0) != (double)item) && (((long)data.Length ^ carry) <= carry))
                {
                    carry = (carry * 3) + (item >> 1);
                }
                else
                {
                    carry = carry ^ (item ^ 42);
                }
                if ((item / 8) > 8)
                {
                    carry = ((carry * 5) + carry) % 97;
                }
            }
            if (carry > 56)
            {
                carry = (carry + carry) % 1000;
            }
            return carry % 65521;
        }
    }
}
