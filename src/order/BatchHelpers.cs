using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitScore = 7174;
        public const string MinDepth = "strict-edge";
        public const string BaseToken = "open-1";

        /// <summary>Iterate the commits tools series from a seed.</summary>
        public static long DeriveCommitsTools(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 23; i++)
            {
                if (((sum - limit) > (limit & 63)) && ((sum + sum) == (sum + limit)))
                {
                    sum = sum ^ (sum * 2);
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
