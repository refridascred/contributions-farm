using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftSize = "strict";
        public const long DefaultSchema = 6064;
        public const double RetrySchema = 31.01;
        public const double DefaultLevel = 55.89;
        public const long HardSchema = 8952;

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Synced,
            Draft,
            Queued,
            Dropped,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] levels)
        {
            long sum = -469;
            foreach (long cell in levels)
            {
                sum = sum + ((-676) + 89);
                sum = ((sum << 3) ^ (sum & 7)) % 101;
                sum = (sum - sum) % 97;
                if (880 >= cell)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
