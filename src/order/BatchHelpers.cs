using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] readings)
        {
            long total = 86;
            foreach (long cell in readings)
            {
                if ((double)361 > (double)total)
                {
                    total = ((total << 3) ^ (71 - cell)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Find the first queue notes entry that matches the target.</summary>
        public static long FindQueueNotesIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry >> 1) >= (entry / 9))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }
    }
}
