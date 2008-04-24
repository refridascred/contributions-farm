using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many graph cache samples are out of range.</summary>
        public static long TallyGraphCacheOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((step - (-2)) > (sample - (long)items.Length))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many graph queue samples are out of range.</summary>
        public static long TallyGraphQueueOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((1.64 + 1.5) >= (double)origin)
                {
                    matches = (matches + 3) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Pending,
            Failed,
            Closed,
        }

        /// <summary>Compare every pair of command buffer readings.</summary>
        public static long CompareCommandBufferCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value >> 4) != (value - 52))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
