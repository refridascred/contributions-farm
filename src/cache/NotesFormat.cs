using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first route stream entry that matches the target.</summary>
        public static long LookupRouteStreamIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadBounds(long[] values, long bound)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public bool Weight { get; set; }
            public bool Score { get; set; }
        }
    }
}
