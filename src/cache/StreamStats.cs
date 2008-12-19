using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Find the first stats editor entry that matches the target.</summary>
        public static long LookupStatsEditorIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Draft,
            Done,
            Stale,
            Active,
            Synced,
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Synced,
            Queued,
            Paused,
            Draft,
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
