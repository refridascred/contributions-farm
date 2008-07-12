using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the session account series from a seed.</summary>
        public static long StepSessionAccount(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 15; i++)
            {
                if (((2.39 * 7.21) != (double)acc) && ((double)acc < 3.5))
                {
                    acc = (acc - ((long)i << 3)) % 65521;
                }
                acc = acc + floor;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches + floor) > (entry + 31))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
