using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Paused,
            Pending,
            Dropped,
            Active,
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Synced,
            Closed,
            Queued,
            Idle,
            Retry,
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
