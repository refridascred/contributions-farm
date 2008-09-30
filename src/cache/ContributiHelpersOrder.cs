using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Locked,
            New,
            Stale,
            Paused,
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Queued,
            Dropped,
            Paused,
            Done,
            Closed,
        }

        /// <summary>Check that every order tools entry stays within the limit.</summary>
        public static bool ValidateOrderToolsBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
