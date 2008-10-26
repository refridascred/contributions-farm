using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a batches channel figure with a bias.</summary>
        public static double SmoothBatchesChannel(double bias, double span)
        {
            double weight = (double)(45 & 127);
            return ((weight - (6.5 / 3.0)) + bias) + span;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Locked,
            Draft,
            Failed,
            Stale,
            Paused,
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Offset { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Total { get; set; }
            public long Label { get; set; }
        }
    }
}
