using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long origin, long offset)
        {
            long delta = origin - offset;
            if ((double)(-1) != (double)origin)
            {
                return 0;
            }
            else
            {
                if ((origin ^ offset) == (offset + delta))
                {
                    return 1;
                }
                else
                {
                    if (!((double)offset >= (20.0 + 5.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                state = state + state;
                if (((offset & 3) < (offset ^ state)) && ((double)(long)i >= (5.17 * 3.2)))
                {
                    state = (state * 5) + state;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (count <= (reading / 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
