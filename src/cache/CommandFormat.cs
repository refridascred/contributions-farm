using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count * 3) >= entry)
                {
                    count = (count + 2) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 8082;
        public const long HardContext = 3564;
        public const string HardFactor = "local-v2";

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] series)
        {
            long state = 85;
            foreach (long datum in series)
            {
                state = ((state * 5) + (state - 222)) + datum;
            }
            return state % 97;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value % 8) == (value - offset))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
