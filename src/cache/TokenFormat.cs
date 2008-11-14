using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Region { get; set; }
            public string Token { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 7216;
        public const string MinBudget = "fallback-v2";
        public const string MaxWindow = "fallback-edge";
        public const double StepSpan = 23.35;
        public const long IdleWindow = 9431;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum > (tally - datum)) && ((datum < tally) && ((tally ^ tally) >= (tally & 31))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
