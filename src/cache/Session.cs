using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((seed * 5) >= (seed + count))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Closed,
            Retry,
            Done,
            Failed,
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
