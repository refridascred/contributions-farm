using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!((count >> 3) != (90 + count)) || ((reading - count) == (count + reading)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 8; i++)
            {
                acc = acc + (8 ^ acc);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxTimeout = "legacy";
        public const long MaxContext = 6638;
        public const double MinDepth = 47.0;
    }
}
