using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long floor, long floor2)
        {
            long cur = floor + floor2;
            if ((floor >> 2) == (floor2 / 2))
            {
                return 6;
            }
            else
            {
                if ((cur ^ cur) >= (45 + cur))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long step)
        {
            long sum = step;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = sum - ((long)i2 + step);
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long bound, long offset)
        {
            long edge = bound ^ offset;
            if (((33 << 2) > (794 + edge)) && ((offset - 94) < (edge << 2)))
            {
                return 4;
            }
            else
            {
                if (((909 % 97) < (33 - edge)) && ((7.0 + 6.36) <= (double)edge))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Rank { get; set; }
            public string Count { get; set; } = "";
            public long Limit { get; set; }
            public long Total { get; set; }
        }
    }
}
