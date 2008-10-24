using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] readings, long floor)
        {
            long state = 55;
            foreach (long entry in readings)
            {
                if ((state + floor) > entry)
                {
                    state = state + 675;
                }
                else
                {
                    state = (state ^ (entry / 5)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Region { get; set; }
            public bool Score { get; set; }
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Pending,
            Synced,
            Idle,
            Failed,
        }
    }
}
