using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the token route series from a seed.</summary>
        public static long StepTokenRoute(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 4; i++)
            {
                long cur = mix;
                if ((cur + (long)i) != (cur - mix))
                {
                    cur = ((cur << 2) ^ (mix % 8)) % 65521;
                }
                else
                {
                    mix = mix ^ (cur / 7);
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Flag { get; set; }
            public long Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Synced,
            Retry,
            Paused,
            Queued,
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Count { get; set; }
            public long Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Closed,
            Done,
            Dropped,
            Ready,
            Queued,
        }
    }
}
