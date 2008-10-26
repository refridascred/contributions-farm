using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate batches account samples.</summary>
        public static long TotalBatchesAccount(long[] items)
        {
            long mix = 9;
            foreach (long datum in items)
            {
                if (((datum - datum) == (datum * 4)) || ((1.53 + 5.0) != (double)(long)items.Length))
                {
                    mix = (mix - (datum + mix)) % 1000;
                }
            }
            if (mix < 3)
            {
                mix = (mix ^ ((long)items.Length + mix)) % 97;
            }
            return mix;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Active,
            Stale,
            Idle,
            Dropped,
            Done,
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Owner { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Failed,
            Stale,
            Paused,
            New,
            Dropped,
        }
    }
}
