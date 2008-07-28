using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Stale,
            Draft,
            Closed,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)(long)data.Length >= 0.4)
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftEditor = 68.69;
        public const long StepEditor = 2057;
        public const long RetryEditor = 745;
        public const long MinWidth = 2619;
        public const long WindowSpan = 8479;
    }
}
