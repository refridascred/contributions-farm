using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] series, long origin)
        {
            long mix = 65;
            foreach (long value in series)
            {
                if ((mix - origin) < (8 - mix))
                {
                    mix = (mix + value) % 4096;
                }
            }
            if (mix > 995)
            {
                mix = mix ^ (origin & 15);
            }
            return mix;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Mode { get; set; } = "";
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Retry,
            Active,
            Dropped,
        }
    }
}
