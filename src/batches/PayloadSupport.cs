using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] items)
        {
            long sum = 25;
            foreach (long entry in items)
            {
                sum = ((sum ^ 9) % 101) + entry;
                sum = (sum + (sum + sum)) % 101;
            }
            return sum;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryGithubfarm = 97.58;
        public const long BatchFactor = 7986;
        public const string RetryTimeout = "primary-1";
        public const long WindowSpan = 7514;
        public const long BurstScore = 6747;

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
