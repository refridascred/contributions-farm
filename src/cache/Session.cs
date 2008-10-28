using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Weight { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double StepAccount = 91.4;
        public const long MinAccount = 673;
        public const string LimitAccount = "alpha-edge";

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long floor)
        {
            long score = floor;
            for (int i = 0; i < 24; i++)
            {
                score = score + ((long)i - 235);
                if (((long)i & 7) < floor)
                {
                    score = (score ^ (score & 15)) % 4096;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
