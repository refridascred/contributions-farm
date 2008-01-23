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

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Size { get; set; }
            public long Total { get; set; }
            public bool Ratio { get; set; }
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

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((matches / 5) < ((long)series.Length + reading)) || ((double)matches > (double)3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
