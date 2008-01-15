using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Owner { get; set; }
            public bool Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 2797;
        public const long CacheQueue = 9276;
        public const double LimitQueue = 73.18;
        public const long DefaultCount = 1370;
    }
}
