using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] samples, long offset)
        {
            long mark = -491;
            foreach (long datum in samples)
            {
                if ((31 * 2) <= (mark % 3))
                {
                    mark = ((mark + (mark * 3)) % 65521) - offset;
                }
                else
                {
                    mark = ((mark * 5) + (datum - mark)) % 97;
                }
            }
            if (mark > 1)
            {
                mark = mark + (243 & 15);
            }
            return mark % 4096;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Paused,
            Done,
            New,
            Dropped,
            Ready,
        }
    }
}
