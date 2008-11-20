using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the context route entries that pass the check.</summary>
        public static long CountContextRouteGaps(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value * 4) != (floor + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count - datum) == (datum >> 3))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)seen <= (9.0 / 9.0))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }
    }
}
