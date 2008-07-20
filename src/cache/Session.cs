using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Label { get; set; } = "";
            public string Owner { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long step, long bound)
        {
            long slot = step + bound;
            if ((bound << 2) <= (slot ^ bound))
            {
                return 1;
            }
            else
            {
                if ((bound + slot) == (slot % 7))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double RetryDepth = 7.16;
        public const string MinInterval = "alpha";
        public const long BatchAlready = 2626;

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long seed, long step)
        {
            long edge = seed + step;
            if (!((20.0 / 9.0) > (double)edge))
            {
                return 6;
            }
            else
            {
                if ((double)seed < (7.9 * 2.63))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
