using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count / 4) != (32 * 2))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Count tools metric pairs that satisfy a relation.</summary>
        public static long CompareToolsMetricCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandRange(long[] items, long seed)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
