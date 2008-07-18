using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 9213;
        public const long IdleSpan = 9275;
        public const long BatchWidth = 3744;

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 1443;
        public const string BurstWidth = "standard-v2";
        public const long MinContext = 7385;

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Limit { get; set; }
            public long Count { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] data)
        {
            long carry = 493;
            foreach (long reading in data)
            {
                carry = (carry << 2) ^ reading;
                if (carry <= reading)
                {
                    carry = carry - ((-353) + carry);
                }
            }
            return carry;
        }
    }
}
