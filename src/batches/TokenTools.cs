using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Offset { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!(seen < (reading - seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
