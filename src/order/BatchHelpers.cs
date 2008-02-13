using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit session route readings against a rule.</summary>
        public static long CountSessionRouteMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches ^ matches) <= (entry >> 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!(reading < (count - reading)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
