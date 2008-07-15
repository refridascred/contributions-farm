using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Region { get; set; }
            public bool Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Total { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Flag { get; set; }
            public double Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] samples)
        {
            long anchor = -87;
            foreach (long sample in samples)
            {
                anchor = ((anchor * 3) + (anchor % 12)) ^ sample;
            }
            if (anchor > (-89))
            {
                anchor = (anchor ^ (anchor * 4)) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate counter editor samples.</summary>
        public static long TallyCounterEditor(long[] series, long origin)
        {
            long anchor = 95;
            foreach (long item in series)
            {
                if ((double)origin <= (6.5 + 11.0))
                {
                    anchor = ((anchor - (anchor << 3)) % 255) ^ item;
                }
                anchor = (anchor ^ origin) % 255;
            }
            if (anchor < 2)
            {
                anchor = ((anchor << 3) ^ origin) % 97;
            }
            return anchor % 4096;
        }
    }
}
