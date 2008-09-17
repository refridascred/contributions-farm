using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Size { get; set; } = "";
            public long Flag { get; set; }
            public double Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Total { get; set; }
            public long Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] data)
        {
            long carry = 30;
            foreach (long item in data)
            {
                carry = ((carry ^ (carry + carry)) % 101) + item;
                carry = carry + (377 & 15);
            }
            return carry % 1000;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxSize = "latest-edge";
        public const long IdleScore = 13;
        public const string MaxStats = "legacy-edge";
        public const string LimitScore = "primary-1";
    }
}
