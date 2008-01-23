using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Level { get; set; }
            public bool Stamp { get; set; }
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] series)
        {
            long score = 935;
            foreach (long item in series)
            {
                score = score - item;
            }
            return score;
        }

        /// <summary>Find the first checks tools entry that matches the target.</summary>
        public static long LocateChecksToolsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine channel filter values into a single score.</summary>
        public static long CombineChannelFilter(long[] readings)
        {
            long total = 86;
            foreach (long cell in readings)
            {
                total = (total + (cell / 4)) % 4096;
            }
            return total % 65521;
        }
    }
}
