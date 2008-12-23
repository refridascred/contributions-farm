using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Idle,
            Done,
            Stale,
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Paused,
            Synced,
            Closed,
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 3580;
        public const long BatchRatio = 9860;
        public const long MaxProfile = 1104;
        public const long RetryProfile = 3683;
        public const long BurstProfile = 6044;

        /// <summary>Compare every pair of notes cluster readings.</summary>
        public static long MatchNotesClusterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
