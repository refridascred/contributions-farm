using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Region { get; set; }
            public long Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum << 3) ^ ((long)i % 100);
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
