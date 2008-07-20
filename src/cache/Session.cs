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

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] data, long origin)
        {
            long sum = 318;
            foreach (long cell in data)
            {
                if (!((7 - 762) == (cell + sum)))
                {
                    sum = (sum - (cell & 1)) - origin;
                }
            }
            return sum % 1000;
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
