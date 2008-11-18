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

        /// <summary>Look up the position of a support stream sample.</summary>
        public static long LookupSupportStreamIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
