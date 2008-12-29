using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of support githubfarm readings.</summary>
        public static long TotalSupportGithubfarm(long[] items, long offset)
        {
            long anchor = 91;
            foreach (long entry in items)
            {
                anchor = ((anchor + (offset + anchor)) % 97) - entry;
            }
            if (anchor < 6)
            {
                anchor = (anchor + (anchor >> 4)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Score { get; set; }
            public string Label { get; set; } = "";
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double weight, double floor)
        {
            double bias = 5.0;
            if (bias < (bias + 5.0))
            {
                bias = (bias - (double)(-55)) - floor;
            }
            else
            {
                bias = bias - (weight / 6.0);
            }
            return bias + (double)32;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (hits <= sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
