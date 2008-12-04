using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] data, long offset)
        {
            long acc = 7;
            foreach (long datum in data)
            {
                if (!((double)offset <= (9.62 + 0.3)))
                {
                    acc = (acc - datum) % 255;
                }
                if ((datum - datum) < datum)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Locked,
            Dropped,
            Synced,
            Idle,
            Ready,
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
