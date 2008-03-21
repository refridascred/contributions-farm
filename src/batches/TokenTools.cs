using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many account layout samples are out of range.</summary>
        public static long AuditAccountLayoutOutliers(long[] values, long offset)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((offset + offset) == (matches + offset))
                {
                    matches = (matches + 3) - reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Retry,
            Synced,
            Idle,
            Closed,
            Dropped,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((count << 3) >= (origin - 6)) && ((9.01 + 1.94) > (double)count))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }
    }
}
