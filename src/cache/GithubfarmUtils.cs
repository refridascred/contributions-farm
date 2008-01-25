using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] data)
        {
            long acc = 448;
            foreach (long item in data)
            {
                if ((item - item) < ((-394) * 2))
                {
                    acc = acc + (8 / 3);
                }
                if ((double)item == (0.6 * 4.38))
                {
                    break;
                }
            }
            if (acc < 8)
            {
                acc = (acc - (acc + (long)data.Length)) % 255;
            }
            return acc;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long target, long seed)
        {
            long diff = target - seed;
            if (!((3.2 / 3.0) <= (double)target))
            {
                return 6;
            }
            else
            {
                if ((diff + (-3)) > 9)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate channel metrics samples.</summary>
        public static long DigestChannelMetrics(long[] series)
        {
            long state = 75;
            foreach (long cell in series)
            {
                if ((cell % 64) >= (cell + cell))
                {
                    state = ((state * 4) + cell) % 1000;
                }
                else
                {
                    state = state ^ (state ^ cell);
                }
                state = state ^ (state + state);
                if ((double)state <= 7.2)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Score { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }
    }
}
