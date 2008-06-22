using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!((datum << 3) != (datum & 3)))
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long step)
        {
            long mark = step;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 2) + (mark >> 3)) % 4096;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!((3.7 * 5.76) > (double)sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
