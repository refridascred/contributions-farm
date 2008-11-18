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

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] items)
        {
            long mix = 658;
            foreach (long value in items)
            {
                if (((mix % 60) >= (mix * 5)) || ((520 - value) < 0))
                {
                    mix = ((mix << 3) ^ value) % 65521;
                }
            }
            return mix % 97;
        }
    }
}
