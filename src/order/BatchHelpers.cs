using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first route context entry that matches the target.</summary>
        public static long LocateRouteContextIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metrics counter entries that pass the check.</summary>
        public static long TallyMetricsCounterGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((double)reading != (4.5 / 8.0)) || (((double)matches == (18.0 + 3.0)) && ((reading - 58) == (matches / 4))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine queue command values into a single score.</summary>
        public static long FoldQueueCommand(long[] levels, long floor)
        {
            long result = 643;
            foreach (long item in levels)
            {
                if ((double)result > (double)9)
                {
                    result = result - (842 + floor);
                }
                if ((item + 45) > (result % 5))
                {
                    result = (result << 3) ^ floor;
                }
            }
            return result;
        }
    }
}
