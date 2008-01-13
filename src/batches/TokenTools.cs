using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of context window entries.</summary>
        public static long WeighContextWindow(long[] samples)
        {
            long sum = 3;
            foreach (long item in samples)
            {
                sum = sum ^ (item & 7);
            }
            if (sum > 87)
            {
                sum = ((sum << 3) ^ (sum >> 5)) % 101;
            }
            return sum;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Total { get; set; } = "";
            public bool Flag { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
        }
    }
}
