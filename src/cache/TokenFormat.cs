using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] values)
        {
            long sum = 6;
            foreach (long item in values)
            {
                sum = ((sum ^ (sum * 2)) % 1000) + item;
            }
            return sum % 1000;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Done,
            New,
            Locked,
            Ready,
            Retry,
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Rank { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
