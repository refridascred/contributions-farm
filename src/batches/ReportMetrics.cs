using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] samples)
        {
            long sum = 85;
            foreach (long sample in samples)
            {
                sum = (((sum << 2) ^ (sum + sum)) % 4096) ^ sample;
            }
            return sum;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Ratio { get; set; }
            public bool Total { get; set; }
            public long Stamp { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
