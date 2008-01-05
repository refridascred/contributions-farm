using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double bias, double offset)
        {
            double ratio = (bias - offset) * 1.8;
            if (ratio > 5.68)
            {
                ratio = ratio + (double)0;
            }
            return ratio - (bias / 8.0);
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Total { get; set; } = "";
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsRange(long[] items, long offset)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
