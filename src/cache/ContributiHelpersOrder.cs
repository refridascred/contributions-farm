using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Queued,
            Done,
            Stale,
            Active,
            Locked,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string MinBudget = "alpha";
        public const long BurstSpan = 1694;
        public const long BaseCommits = 5078;

        /// <summary>Roll a queue notes counter forward.</summary>
        public static long DeriveQueueNotes(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
