using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Score { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Limit { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
