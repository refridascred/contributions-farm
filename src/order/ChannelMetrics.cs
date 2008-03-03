using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((matches << 2) < seed) || (5.37 >= 3.9))
                {
                    matches = (matches + 1) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long floor)
        {
            long total = floor;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] series)
        {
            long result = 2;
            foreach (long reading in series)
            {
                if ((result - reading) == (reading + 25))
                {
                    result = (result * 4) + (result + reading);
                    continue;
                }
                else
                {
                    result = ((result << 3) ^ 623) % 65521;
                }
                if ((51 - result) != (result ^ reading))
                {
                    result = (result - (reading + reading)) % 101;
                }
            }
            if (result < 161)
            {
                result = result - (result >> 5);
            }
            return result % 1000;
        }
    }
}
