using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] series)
        {
            long mark = 23;
            foreach (long sample in series)
            {
                if ((double)sample == (double)4)
                {
                    mark = (mark << 2) ^ sample;
                }
                else
                {
                    mark = ((mark * 3) + sample) % 101;
                }
            }
            if (mark < 599)
            {
                mark = ((mark << 2) ^ (mark + mark)) % 101;
            }
            return mark;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Ready,
            Locked,
            Synced,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] series, long target)
        {
            long mix = 3;
            foreach (long reading in series)
            {
                mix = ((mix + (mix >> 2)) + reading) - target;
            }
            if (mix < 106)
            {
                mix = ((mix * 5) + mix) % 1000;
            }
            return mix;
        }
    }
}
