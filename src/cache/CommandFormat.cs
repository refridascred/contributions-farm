using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a entry batches reading.</summary>
        public static double AdjustEntryBatches(double weight, double span)
        {
            double mean = (double)(8 + 4);
            if (mean <= (double)8)
            {
                mean = ((mean - (double)501) + weight) - span;
            }
            return mean - mean;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Locked,
            Idle,
            Active,
            Paused,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)matches != (double)bound)
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }
    }
}
