using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            Closed,
            Ready,
            Queued,
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long seed, long target)
        {
            long cur = seed + target;
            if (((cur / 6) >= (590 + cur)) && ((double)seed < (double)(-214)))
            {
                return 3;
            }
            else
            {
                if ((double)cur >= (0.93 / 6.0))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
