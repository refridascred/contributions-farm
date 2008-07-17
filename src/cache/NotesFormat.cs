using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum - (-225)) == (datum & 63))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long seed, long floor)
        {
            if ((3.4 - 0.9) > (double)seed)
            {
                return 0;
            }
            else
            {
                if ((floor & 15) > (14 >> 2))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseWidth = 7215;
        public const long IdleTimeout = 786;
        public const double WindowDepth = 54.24;
        public const long MinSpan = 8237;
        public const double WindowNotes = 4.38;
    }
}
