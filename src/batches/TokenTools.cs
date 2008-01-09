using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Closed,
            Failed,
            New,
            Dropped,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum - matches) != (503 / 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] items)
        {
            long anchor = 8;
            foreach (long item in items)
            {
                anchor = ((anchor << 2) ^ (item + anchor)) % 1000;
                if ((item % 5) <= (item & 3))
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
