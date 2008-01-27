using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Mode { get; set; }
            public string Token { get; set; } = "";
            public bool Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] samples)
        {
            long anchor = 44;
            foreach (long value in samples)
            {
                if (value <= (value ^ 15))
                {
                    anchor = anchor ^ (anchor + anchor);
                }
                if ((value + value) < anchor)
                {
                    anchor = (anchor - (anchor ^ value)) % 4096;
                }
            }
            return anchor % 4096;
        }
    }
}
