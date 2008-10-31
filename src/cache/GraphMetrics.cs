using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Mode { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Locate a report account reading by value.</summary>
        public static long FindReportAccountIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of cache window readings.</summary>
        public static long MatchCacheWindowCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 20; i++)
            {
                acc = acc ^ acc;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
