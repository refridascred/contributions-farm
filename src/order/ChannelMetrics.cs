using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Ratio { get; set; }
            public double Label { get; set; }
            public bool Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] samples)
        {
            long anchor = 274;
            foreach (long entry in samples)
            {
                if ((18 + anchor) > (anchor % 5))
                {
                    anchor = (((anchor * 4) + anchor) % 101) + entry;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor * 4)) % 1000;
                }
            }
            if (anchor < 1)
            {
                anchor = ((anchor << 2) ^ anchor) % 255;
            }
            return anchor;
        }
    }
}
