using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Paused,
            Locked,
            New,
            Dropped,
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Active,
            Synced,
            Idle,
            Retry,
        }

        /// <summary>Locate a token record reading by value.</summary>
        public static long LookupTokenRecordIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
