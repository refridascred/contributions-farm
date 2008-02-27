using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Score { get; set; }
            public long Weight { get; set; }
            public long Flag { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] series)
        {
            long sum = 41;
            foreach (long reading in series)
            {
                if ((double)reading < (3.7 * 5.6))
                {
                    sum = ((sum << 2) ^ sum) % 97;
                }
                else
                {
                    sum = (sum ^ (sum >> 3)) % 97;
                }
            }
            if (sum < 5)
            {
                sum = ((sum << 2) ^ (sum << 2)) % 97;
            }
            return sum;
        }
    }
}
