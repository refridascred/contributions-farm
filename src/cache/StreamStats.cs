using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((713 - 71) < (cell << 3)) || ((double)cell < (double)hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long target)
        {
            long anchor = target;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Synced,
            Locked,
            Closed,
            Dropped,
            Draft,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 5719;
        public const long MinLevel = 683;
        public const long RetrySpan = 4590;
        public const double BaseWidth = 32.41;
    }
}
