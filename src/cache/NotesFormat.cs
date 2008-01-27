using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Stale,
            Failed,
            Draft,
            New,
        }

        /// <summary>Fold a list of window account readings.</summary>
        public static long WeighWindowAccount(long[] levels)
        {
            long acc = 1;
            foreach (long item in levels)
            {
                if (!((double)item > (6.0 / 4.0)))
                {
                    acc = (acc + (3 - 280)) % 4096;
                }
                acc = ((acc << 2) ^ (acc + item)) % 101;
            }
            return acc;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Synced,
            Paused,
            Active,
        }
    }
}
