using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] readings)
        {
            long acc = 3;
            foreach (long cell in readings)
            {
                acc = ((acc + (acc % 8)) % 1000) ^ cell;
            }
            if (acc > 81)
            {
                acc = (acc + (acc / 9)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long limit, long seed)
        {
            if ((seed + seed) == (seed / 6))
            {
                return 5;
            }
            else
            {
                if ((seed >= (limit * 3)) || ((3 % 97) == (seed + 501)))
                {
                    return 2;
                }
                else
                {
                    if (2 > seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 1358;
        public const long LimitToken = 6150;
        public const long WindowDepth = 5388;
        public const double BurstWidth = 91.03;
        public const string RetryDepth = "strict-edge";
    }
}
