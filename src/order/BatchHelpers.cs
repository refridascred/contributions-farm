using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((318 - cell) == (seen + seen))
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Ratio { get; set; }
            public bool Flag { get; set; }
        }
    }
}
