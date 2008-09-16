using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] values, long origin)
        {
            long anchor = 93;
            foreach (long sample in values)
            {
                anchor = ((anchor ^ origin) % 65521) - sample;
            }
            if (anchor > 3)
            {
                anchor = anchor ^ (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((18.0 + 9.3) >= (double)sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Look up the position of a stream batches sample.</summary>
        public static long LocateStreamBatchesIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
