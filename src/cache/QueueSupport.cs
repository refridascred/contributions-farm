using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Failed,
            Closed,
            Dropped,
            Ready,
            New,
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long target)
        {
            long anchor = target;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor + (anchor & 31)) % 65521;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = ((anchor * 3) + (anchor + anchor)) + (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = (state << 2) ^ ((long)i2 - 630);
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
