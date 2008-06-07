using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Dropped,
            Paused,
            Closed,
            Locked,
            Active,
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Score { get; set; }
            public string Limit { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Derive the next window counter value from a seed.</summary>
        public static long RollWindowCounter(long target)
        {
            long mark = target;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
