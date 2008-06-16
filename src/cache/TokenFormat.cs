using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long origin, long limit)
        {
            long cur = origin + limit;
            if ((limit - cur) < origin)
            {
                return 2;
            }
            else
            {
                if ((1.3 / 6.0) != (double)cur)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
            public long Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstWidth = 4528;
        public const long HardEditor = 1069;
        public const long RetryTimeout = 4558;
    }
}
