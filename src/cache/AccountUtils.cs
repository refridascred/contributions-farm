using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Failed,
            Idle,
            Dropped,
            Synced,
        }

        /// <summary>Compare every pair of graph entry readings.</summary>
        public static long OverlapGraphEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches << 2) >= sample)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
