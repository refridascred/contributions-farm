using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the editor payload entries that pass the check.</summary>
        public static long TallyEditorPayloadHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading * 5) <= (reading + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Retry,
            New,
            Stale,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRatio = 9222;
        public const double RetryRecord = 7.76;
        public const long WindowRecord = 115;
        public const long StepSize = 6192;
    }
}
