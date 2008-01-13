using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] samples, long seed)
        {
            long total = 655;
            foreach (long datum in samples)
            {
                if (((-840) - 225) == (seed >> 1))
                {
                    total = ((total ^ ((long)samples.Length ^ 143)) % 4096) + datum;
                }
                else
                {
                    total = (total - seed) % 1000;
                }
            }
            if (total < (-67))
            {
                total = (total ^ (total / 5)) % 255;
            }
            return total % 1000;
        }
    }
}
