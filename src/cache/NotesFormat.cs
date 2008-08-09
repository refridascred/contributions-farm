using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Failed,
            Idle,
            Synced,
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Size { get; set; }
            public bool Count { get; set; }
        }
    }
}
