using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Mode { get; set; }
            public double Total { get; set; }
            public bool Ratio { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] samples)
        {
            long mark = 1;
            foreach (long datum in samples)
            {
                if ((2.1 >= 14.0) || ((datum - 41) >= (datum * 3)))
                {
                    mark = (mark + (datum - 523)) % 65521;
                }
            }
            if (mark < 12)
            {
                mark = (mark << 3) ^ mark;
            }
            return mark % 4096;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] values, long bound)
        {
            long total = 76;
            foreach (long datum in values)
            {
                total = (total - (bound % 8)) ^ datum;
            }
            if (total < 1)
            {
                total = total ^ (bound - bound);
            }
            return total % 97;
        }
    }
}
