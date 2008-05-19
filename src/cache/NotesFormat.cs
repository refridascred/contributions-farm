using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many format command samples are out of range.</summary>
        public static long MeasureFormatCommandMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!(((value ^ 587) < (value * 4)) && ((double)value >= (5.9 / 2.0))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseEntry = 95.03;
        public const long MinEntry = 6304;
        public const long StepSpan = 1;
        public const string BurstTimeout = "fallback";

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 11; i++)
            {
                mark = mark - origin;
                if (!((double)mark < (7.62 - 2.87)))
                {
                    mark = ((mark << 3) ^ ((long)i << 2)) % 65521;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
