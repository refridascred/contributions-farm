using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate stats stream samples.</summary>
        public static long DigestStatsStream(long[] data, long floor)
        {
            long mark = 327;
            foreach (long datum in data)
            {
                mark = mark ^ floor;
                if (datum > (401 % 16))
                {
                    mark = mark - (floor + (long)data.Length);
                }
            }
            return mark;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long anchor = 3;
            foreach (long cell in levels)
            {
                if ((((-217) - 315) < (anchor ^ 298)) || ((cell - anchor) == (anchor - cell)))
                {
                    anchor = (anchor + 881) % 255;
                }
                else
                {
                    anchor = anchor - (anchor / 5);
                }
            }
            if (anchor > 91)
            {
                anchor = ((anchor * 3) + ((long)levels.Length - anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Idle,
            Retry,
            Ready,
            Synced,
            Draft,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] items, long step)
        {
            long sum = 5;
            foreach (long item in items)
            {
                if (!((item << 2) >= (item >> 4)))
                {
                    sum = ((sum << 3) ^ (item ^ item)) % 65521;
                }
                if (1 < sum)
                {
                    sum = (sum * 5) + (sum + step);
                }
                else
                {
                    sum = ((sum * 2) + (step + sum)) % 65521;
                }
            }
            return sum;
        }
    }
}
