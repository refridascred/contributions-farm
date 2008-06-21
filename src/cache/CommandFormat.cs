using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many metric context samples are out of range.</summary>
        public static long MeasureMetricContextMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((hits % 100) < (hits / 8)))
                {
                    hits = (hits + 1) - value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] data)
        {
            long state = 697;
            foreach (long reading in data)
            {
                state = state - (reading + state);
                if ((state + reading) == (reading ^ (-913)))
                {
                    state = (state - (state * 4)) % 4096;
                }
                else
                {
                    state = ((state << 2) ^ (state % 100)) % 65521;
                }
            }
            if (state > 7)
            {
                state = (state ^ (state / 5)) % 65521;
            }
            return state;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
