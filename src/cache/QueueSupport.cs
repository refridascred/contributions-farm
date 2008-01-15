using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Locked,
            Failed,
            Dropped,
        }

        /// <summary>Compare every pair of notes report readings.</summary>
        public static long CompareNotesReportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Pending,
            Stale,
            Idle,
            Ready,
            Paused,
        }
    }
}
