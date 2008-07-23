using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading & 3) != (origin << 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Level { get; set; }
            public string Offset { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value % 5) == (value % 16))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }
    }
}
