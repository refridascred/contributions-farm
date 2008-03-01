using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] values, long seed)
        {
            long acc = 253;
            foreach (long entry in values)
            {
                if ((entry ^ entry) < entry)
                {
                    acc = ((acc - (entry - entry)) % 65521) - seed;
                }
            }
            return acc % 97;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Idle,
            Active,
            Stale,
            Dropped,
            Failed,
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Dropped,
            Locked,
            Active,
            Failed,
            Pending,
        }
    }
}
