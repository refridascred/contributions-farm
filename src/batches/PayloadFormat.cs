using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseFactor = 9968;
        public const long DefaultBudget = 4300;
        public const long RetryCommits = 7848;
        public const string RetryScore = "cached-v2";

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Paused,
            Pending,
            Queued,
            Ready,
            Failed,
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Limit { get; set; } = "";
            public long Level { get; set; }
            public double Token { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
