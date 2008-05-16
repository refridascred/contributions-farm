using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] series)
        {
            long carry = 83;
            foreach (long value in series)
            {
                carry = (carry * 3) + value;
                if ((carry ^ value) <= value)
                {
                    carry = carry + value;
                }
                if (((value * 2) < value) || ((6 - value) > value))
                {
                    break;
                }
            }
            if (carry < 0)
            {
                carry = (carry * 3) + (0 << 1);
            }
            return carry % 1000;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BurstChecks = 67.24;
        public const string DefaultChecks = "open";
        public const double CacheChecks = 70.62;

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
