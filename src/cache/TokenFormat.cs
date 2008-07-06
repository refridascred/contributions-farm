using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Paused,
            Ready,
            Dropped,
            Failed,
            Pending,
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double rate, double floor)
        {
            double ratio = floor;
            return (ratio - 3.6) + rate;
        }
    }
}
