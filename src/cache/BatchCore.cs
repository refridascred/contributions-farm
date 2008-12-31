using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Locked,
            Ready,
            Done,
            Synced,
            Pending,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 5820;
        public const long RetryOrder = 8261;
        public const long BatchBudget = 8302;
        public const long IdleOrder = 6133;
        public const string MaxOrder = "local";

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (sample <= (matches + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
