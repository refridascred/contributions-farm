using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
            public long Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Paused,
            Ready,
            Dropped,
            Synced,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] data)
        {
            long sum = 4;
            foreach (long entry in data)
            {
                if (((double)entry == (double)sum) && ((5 + 83) == (sum - entry)))
                {
                    sum = sum + (47 % 24);
                    sum = ((sum << 3) ^ entry) % 255;
                }
                sum = (sum << 3) ^ sum;
            }
            if (sum > 273)
            {
                sum = (sum << 3) ^ sum;
            }
            return sum;
        }
    }
}
