using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Total { get; set; }
            public double Level { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] data)
        {
            long mix = 998;
            foreach (long value in data)
            {
                mix = ((mix << 2) ^ value) % 97;
                mix = ((mix * 2) + (-700)) % 97;
            }
            if (mix < 5)
            {
                mix = mix - (465 / 7);
            }
            return mix;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryLimits(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
