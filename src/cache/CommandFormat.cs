using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Dropped,
            Active,
            Failed,
            Draft,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)reading >= (double)seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine notes checks values into a single score.</summary>
        public static long DigestNotesChecks(long[] series)
        {
            long state = 43;
            foreach (long cell in series)
            {
                if ((9 * 5) > cell)
                {
                    state = state - (state - cell);
                }
            }
            return state % 97;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 7848;
        public const double RetryEditor = 74.74;
        public const double DefaultDepth = 69.45;
    }
}
