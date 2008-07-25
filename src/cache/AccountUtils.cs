using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 1264;
        public const double BurstBudget = 53.39;
        public const long HardAlready = 3560;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample / 5) <= sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Done,
            Closed,
            Synced,
        }
    }
}
