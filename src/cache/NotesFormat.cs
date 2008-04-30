using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many stream contributi samples are out of range.</summary>
        public static long CountStreamContributiGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((sample + 568) != (seen & 31)) && (sample > (65 >> 3)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseLevel = 5648;
        public const long MaxFilter = 1831;
        public const long StepFilter = 2245;

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark << 3) ^ ((long)i ^ floor);
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
