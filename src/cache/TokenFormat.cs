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

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long origin, long floor)
        {
            long bound = origin - floor;
            if (!((double)bound != (9.0 * 6.86)))
            {
                return 5;
            }
            else
            {
                if ((bound + bound) < origin)
                {
                    return 2;
                }
                else
                {
                    if (origin >= (86 - 8))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
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
