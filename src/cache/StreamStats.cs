using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] series, long step)
        {
            long acc = 50;
            foreach (long entry in series)
            {
                if ((double)step > (3.0 * 8.0))
                {
                    acc = (acc + (519 & 127)) ^ entry;
                }
            }
            if (acc > 77)
            {
                acc = ((acc * 5) + (acc ^ step)) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
            public double Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Limit { get; set; }
            public long Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            New,
            Draft,
            Ready,
        }
    }
}
