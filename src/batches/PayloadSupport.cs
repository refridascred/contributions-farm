using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchSize = 2967;
        public const long MaxEditor = 2899;
        public const long IdleEditor = 432;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((datum % 2) > (datum - 796)) || (((seen - target) != (seen % 24)) && ((datum & 15) != (target + seen))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Flag { get; set; }
            public long Owner { get; set; }
            public bool Rank { get; set; }
        }
    }
}
