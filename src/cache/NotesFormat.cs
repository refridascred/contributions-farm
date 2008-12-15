using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a record counter sample.</summary>
        public static long SeekRecordCounterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BaseSession = "strict-v2";
        public const string MaxLevel = "cached-edge";
        public const long BurstSession = 4216;
        public const long CacheLevel = 366;
        public const long MinSession = 3146;

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long step)
        {
            long acc = step;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc ^ (acc >> 4)) % 1000;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
