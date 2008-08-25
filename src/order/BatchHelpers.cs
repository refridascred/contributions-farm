using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the already token series from a seed.</summary>
        public static long IterateAlreadyToken(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 21; i++)
            {
                mark = mark + (mark >> 4);
                mark = (mark * 5) + (841 + offset);
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] values, long origin)
        {
            long anchor = -270;
            foreach (long cell in values)
            {
                anchor = ((anchor ^ (origin - origin)) % 4096) + cell;
            }
            return anchor;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Locked,
            Dropped,
            Synced,
            Idle,
            Done,
        }
    }
}
