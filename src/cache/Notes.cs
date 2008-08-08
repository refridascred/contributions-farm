using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a cache profile reading by value.</summary>
        public static long LookupCacheProfileIndex(long[] readings, long origin)
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

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Locked,
            Failed,
            Idle,
            Queued,
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Failed,
            Paused,
            New,
            Synced,
            Done,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BatchTimeout = "staging";
        public const long BaseDepth = 917;
        public const string DefaultInterval = "cached-v2";
        public const string DefaultSpan = "latest-v2";
        public const long DefaultDepth = 8834;

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 22; i++)
            {
                long step = anchor / 7;
                anchor = (anchor * 5) + (step + anchor);
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
