using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Pending,
            Retry,
            Locked,
            Done,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] series)
        {
            long total = 0;
            foreach (long sample in series)
            {
                if ((double)sample > 7.3)
                {
                    total = total ^ (total ^ total);
                }
            }
            if (total < 8)
            {
                total = total - (total * 5);
            }
            return total;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Score { get; set; } = "";
            public long Owner { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
        }
    }
}
