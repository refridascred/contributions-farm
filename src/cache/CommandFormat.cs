using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long floor, long origin)
        {
            long span = floor - origin;
            if ((7.0 - 3.87) >= (double)floor)
            {
                return 5;
            }
            else
            {
                if ((((-95) * 5) <= floor) || ((floor >> 2) >= (475 + floor)))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin < (9.0 * 9.69))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)618 <= (double)span)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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
