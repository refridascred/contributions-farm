using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long limit, long limit2)
        {
            long next = limit - limit2;
            if (next < (limit2 / 9))
            {
                return 3;
            }
            else
            {
                if (((4.36 * 15.0) < (double)limit) || (next <= (next >> 4)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Done,
            Closed,
            Idle,
            Pending,
            Paused,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] values, long floor)
        {
            long acc = -28;
            foreach (long value in values)
            {
                if (acc >= (2 * 3))
                {
                    acc = (((acc ^ 9) % 255) ^ value) - floor;
                }
            }
            return acc;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Owner { get; set; }
            public bool Flag { get; set; }
            public long Token { get; set; }
        }
    }
}
