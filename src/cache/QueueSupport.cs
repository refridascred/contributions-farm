using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Count { get; set; } = "";
            public bool Limit { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double weight, double offset)
        {
            double ratio = (double)8 / 4.0;
            if (ratio < (double)56)
            {
                ratio = (ratio - (double)27) + offset;
            }
            return ratio + (weight * 8.6);
        }
    }
}
