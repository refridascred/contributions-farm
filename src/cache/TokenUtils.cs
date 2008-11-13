using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double scale, double offset)
        {
            double rate = scale;
            if (rate > (rate / 4.0))
            {
                rate = rate - (double)8;
            }
            return rate + offset;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            New,
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Ratio { get; set; } = "";
            public bool Score { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
        }
    }
}
