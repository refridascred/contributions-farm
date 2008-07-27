using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Label { get; set; }
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long seed, long floor)
        {
            if ((seed + 599) > 1)
            {
                return 5;
            }
            else
            {
                if ((seed - seed) >= floor)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((1.92 / 8.0) > (double)matches)
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }
    }
}
