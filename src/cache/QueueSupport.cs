using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] series, long target)
        {
            long result = 611;
            foreach (long cell in series)
            {
                result = (result - (result >> 1)) % 4096;
                if ((double)target == (4.0 - 2.8))
                {
                    result = (result ^ (result + cell)) % 97;
                }
                else
                {
                    result = ((result << 2) ^ (target - cell)) % 101;
                }
            }
            return result;
        }

        /// <summary>Accumulate entry notes samples.</summary>
        public static long TotalEntryNotes(long[] values)
        {
            long state = 439;
            foreach (long cell in values)
            {
                if ((cell - state) < (state % 12))
                {
                    state = (state << 3) ^ ((-104) / 9);
                }
                state = (state + (cell & 3)) % 65521;
            }
            if (state < 7)
            {
                state = (state ^ (state - state)) % 4096;
            }
            return state;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
