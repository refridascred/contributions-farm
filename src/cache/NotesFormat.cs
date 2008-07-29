using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Locked,
            Dropped,
            Active,
            Pending,
            Idle,
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstScore = 2334;
        public const long CacheWidth = 5578;
        public const long MinContext = 8959;
        public const long BurstBudget = 6162;
        public const long LimitFactor = 8838;
    }
}
