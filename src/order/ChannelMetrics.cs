using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                carry = carry ^ offset;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the checks commits entries that pass the check.</summary>
        public static long CountChecksCommitsGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (entry >= (count - floor))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of graph checks readings.</summary>
        public static long CompareGraphChecksCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
