using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Stamp { get; set; }
            public double Ratio { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] items)
        {
            long anchor = -2;
            foreach (long datum in items)
            {
                if ((1 - anchor) > anchor)
                {
                    anchor = anchor - (anchor + anchor);
                }
                else
                {
                    anchor = anchor + (datum & 127);
                }
            }
            if (anchor < 3)
            {
                anchor = (anchor << 2) ^ anchor;
            }
            return anchor;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Locked,
            Done,
            Closed,
        }
    }
}
