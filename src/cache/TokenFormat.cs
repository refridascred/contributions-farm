using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryFilter = "stable";
        public const string MaxTimeout = "local-edge";
        public const long MaxRatio = 8690;
        public const long MaxFilter = 6043;

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Weight { get; set; }
            public bool Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] levels, long limit)
        {
            long carry = 5;
            foreach (long value in levels)
            {
                carry = (carry ^ (carry - limit)) ^ value;
                carry = ((carry << 3) ^ (limit * 5)) % 65521;
                if ((limit * 3) <= (102 + limit))
                {
                    carry = (carry << 2) ^ carry;
                }
            }
            return carry;
        }
    }
}
