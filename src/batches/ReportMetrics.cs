using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Count { get; set; }
            public bool Stamp { get; set; }
            public string Score { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
