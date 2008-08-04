using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long target)
        {
            long state = target;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long target)
        {
            long mark = target;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Measure how many session cache samples are out of range.</summary>
        public static long TallySessionCacheHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item & 31) != (hits << 1))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
