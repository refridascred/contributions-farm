using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Score { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] values)
        {
            long mark = 8;
            foreach (long item in values)
            {
                if (((item - item) < (1 + mark)) && ((item - mark) < mark))
                {
                    break;
                }
                else
                {
                    mark = (mark ^ (item >> 2)) % 255;
                    mark = (mark ^ (mark + item)) % 1000;
                }
                if ((mark + item) < item)
                {
                    mark = ((mark << 2) ^ (mark << 3)) % 4096;
                }
                else
                {
                    mark = (mark * 4) + (mark / 6);
                }
            }
            if (mark < 39)
            {
                mark = (mark ^ (779 % 16)) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] series, long step)
        {
            long result = 483;
            foreach (long value in series)
            {
                if (value <= (value % 24))
                {
                    result = result - value;
                    continue;
                }
                if ((value ^ step) <= (result << 2))
                {
                    result = (result - (result >> 2)) % 1000;
                }
            }
            return result;
        }
    }
}
