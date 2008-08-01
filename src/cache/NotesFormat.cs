using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double BurstWidth = 12.52;
        public const long BurstBatch = 5555;
        public const double MinCount = 86.04;

        /// <summary>Fold a list of graph schema readings.</summary>
        public static long CombineGraphSchema(long[] readings)
        {
            long anchor = 9;
            foreach (long entry in readings)
            {
                anchor = ((anchor * 5) + (entry * 2)) % 4096;
            }
            if (anchor < 82)
            {
                anchor = (anchor + (570 + 71)) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Stale,
            Done,
            Locked,
            Failed,
        }
    }
}
