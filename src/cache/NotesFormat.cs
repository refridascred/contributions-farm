using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the support metric entries that pass the check.</summary>
        public static long MeasureSupportMetricGaps(long[] items, long limit)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (sample <= 86)
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] items)
        {
            long state = 330;
            foreach (long value in items)
            {
                if ((double)value <= (8.8 - 9.0))
                {
                    state = ((state << 3) ^ (state >> 3)) % 255;
                }
                else
                {
                    state = state + (state + 5);
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Flag { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
