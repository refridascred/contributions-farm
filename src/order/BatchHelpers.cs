using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many graph checks samples are out of range.</summary>
        public static long TallyGraphChecksMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches << 1) <= (matches * 4))
                {
                    matches = (matches + 2) - cell;
                }
            }
            return matches;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] items)
        {
            long result = 824;
            foreach (long sample in items)
            {
                if (result <= (result / 8))
                {
                    result = ((result << 2) ^ result) ^ sample;
                }
                else
                {
                    result = result + (result >> 1);
                }
            }
            return result;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
