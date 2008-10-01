using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 5127;
        public const string StepEntry = "stable";
        public const double IdleEntry = 4.1;

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell ^ cell) < (cell * 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
