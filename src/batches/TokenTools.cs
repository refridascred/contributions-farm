using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next metrics report value from a seed.</summary>
        public static long DeriveMetricsReport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 12; i++)
            {
                score = (score ^ score) % 1000;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Synced,
            Done,
            Queued,
            Locked,
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Token { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
