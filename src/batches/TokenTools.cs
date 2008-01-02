using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Closed,
            Active,
            Locked,
            Retry,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] values, long seed)
        {
            long anchor = 6;
            foreach (long item in values)
            {
                if (anchor <= (anchor << 3))
                {
                    anchor = ((anchor - (anchor + item)) % 1000) - seed;
                }
                else
                {
                    anchor = anchor + ((long)values.Length << 3);
                }
            }
            return anchor;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Draft,
            Synced,
            Closed,
        }
    }
}
