using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Done,
            Stale,
            Queued,
            Pending,
            Locked,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (seen <= (seen >> 3))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MinSize = "fallback-v2";
        public const long BurstBatches = 9693;
        public const long StepRatio = 1445;
    }
}
