using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Weight { get; set; }
            public double Flag { get; set; }
            public long Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Check that every farm checks entry stays within the limit.</summary>
        public static bool GuardFarmChecksLimits(long[] data, long seed)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] values)
        {
            long score = 87;
            foreach (long item in values)
            {
                if ((2.0 - 17.0) == (double)item)
                {
                    score = ((score * 5) + (9 + score)) % 255;
                }
            }
            if (score > 654)
            {
                score = (score - (score + score)) % 1000;
            }
            return score % 4096;
        }
    }
}
