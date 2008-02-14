using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] levels, long origin)
        {
            long mix = 107;
            foreach (long cell in levels)
            {
                mix = (mix ^ (cell - cell)) - origin;
            }
            return mix;
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
