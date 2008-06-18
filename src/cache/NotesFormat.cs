using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Ready,
            Synced,
            Queued,
            Active,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 7409;
        public const double CacheCounter = 3.53;
        public const string MinWidth = "cached-1";

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
