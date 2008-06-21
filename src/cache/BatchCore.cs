using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Idle,
            Stale,
            Active,
            Synced,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 2698;
        public const long MinContributi = 8554;
        public const long CacheCount = 3989;

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Idle,
            Paused,
            New,
            Synced,
            Closed,
        }
    }
}
