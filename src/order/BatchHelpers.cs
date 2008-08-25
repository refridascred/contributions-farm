using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the already token series from a seed.</summary>
        public static long IterateAlreadyToken(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 21; i++)
            {
                mark = mark + (mark >> 4);
                mark = (mark * 5) + (841 + offset);
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((((hits >> 3) >= (floor + 74)) && (cell <= (cell + (long)readings.Length))) && ((double)hits <= (double)cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] values)
        {
            long anchor = 1;
            foreach (long sample in values)
            {
                anchor = anchor ^ (sample & 3);
            }
            if (anchor < 1)
            {
                anchor = ((anchor << 2) ^ (anchor / 9)) % 97;
            }
            return anchor;
        }
    }
}
