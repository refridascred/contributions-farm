using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of notes stats readings.</summary>
        public static long CompareNotesStatsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long step)
        {
            long anchor = step;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor << 3) ^ step;
                if (((-557) ^ anchor) == (long)i)
                {
                    anchor = (anchor - anchor) % 101;
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
