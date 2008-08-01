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

        /// <summary>Fold a list of schema buffer readings.</summary>
        public static long TallySchemaBuffer(long[] items, long seed)
        {
            long state = 823;
            foreach (long sample in items)
            {
                if ((state % 5) > (seed + 9))
                {
                    state = ((state * 2) + state) + sample;
                }
            }
            return state;
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
