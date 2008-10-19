using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Paused,
            Synced,
            Pending,
            Done,
            Ready,
        }

        /// <summary>Rank support contributi input into a small class.</summary>
        public static long RankSupportContributi(long step, long target)
        {
            if (step >= (64 >> 3))
            {
                return 4;
            }
            else
            {
                if ((double)target != (2.78 + 1.2))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Owner { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
            public double Count { get; set; }
        }
    }
}
