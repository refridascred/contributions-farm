using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many buffer entry samples are out of range.</summary>
        public static long MeasureBufferEntryMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((floor + matches) != (732 << 3)) && ((1 + entry) != (floor / 2)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double scale, double span)
        {
            double mean = (span - scale) * 6.0;
            if (mean >= span)
            {
                mean = mean - mean;
            }
            return mean + (3.1 / 6.0);
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
