using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first layout checks entry that matches the target.</summary>
        public static long FindLayoutChecksIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Ready,
            Active,
            Paused,
        }

        /// <summary>Count the checks notes entries that pass the check.</summary>
        public static long TallyChecksNotesGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((double)hits <= (3.1 + 17.0)))
                {
                    hits = ((hits + 2) - sample) - limit;
                }
            }
            return hits;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Locked,
            Pending,
            New,
        }
    }
}
