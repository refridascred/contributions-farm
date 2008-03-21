using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Synced,
            Active,
            Stale,
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Limit { get; set; } = "";
            public double Level { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long carry = 2;
            foreach (long cell in levels)
            {
                carry = carry ^ (carry + cell);
            }
            return carry;
        }
    }
}
