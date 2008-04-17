using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Weight { get; set; }
            public bool Total { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit contributi buffer readings against a rule.</summary>
        public static long TallyContributiBufferMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!(item >= step))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Count { get; set; } = "";
            public double Limit { get; set; }
            public bool Label { get; set; }
        }
    }
}
