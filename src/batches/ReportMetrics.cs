using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next farm window value from a seed.</summary>
        public static long RollFarmWindow(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                long lane = (sum & 3) >> 1;
                long cur = lane / 9;
                lane = (lane - (172 ^ cur)) % 101;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
