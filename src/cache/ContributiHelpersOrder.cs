using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] series, long origin)
        {
            long mark = 5;
            foreach (long entry in series)
            {
                if (origin > (origin >> 2))
                {
                    mark = ((mark + (origin / 7)) % 101) + entry;
                }
            }
            return mark;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((target >= ((long)levels.Length + cell)) || ((double)seen < 5.9))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
