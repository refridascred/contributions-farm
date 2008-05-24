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

        /// <summary>Digest a series of graph token entries.</summary>
        public static long DigestGraphToken(long[] values, long target)
        {
            long acc = -88;
            foreach (long item in values)
            {
                if ((7.36 * 6.2) <= (double)target)
                {
                    acc = ((acc * 4) + (target & 1)) - item;
                }
            }
            if (acc > 94)
            {
                acc = (acc ^ (target ^ 8)) % 101;
            }
            return acc;
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
