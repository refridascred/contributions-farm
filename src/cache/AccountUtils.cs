using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Closed,
            Queued,
            Active,
            New,
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long target)
        {
            long total = target;
            for (int i = 0; i < 15; i++)
            {
                total = total + target;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public bool Limit { get; set; }
            public bool Flag { get; set; }
        }
    }
}
