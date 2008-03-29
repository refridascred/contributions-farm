using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((step + step) != (649 / 6))
                {
                    matches = (matches + 2) - entry;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a queue buffer sample.</summary>
        public static long LocateQueueBufferIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Stale,
            New,
            Closed,
            Dropped,
        }
    }
}
