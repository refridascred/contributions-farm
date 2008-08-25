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

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Region { get; set; }
            public double Flag { get; set; }
            public long Mode { get; set; }
            public double Weight { get; set; }
        }
    }
}
