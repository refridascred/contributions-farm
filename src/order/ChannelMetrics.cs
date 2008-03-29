using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] data, long seed)
        {
            long state = 988;
            foreach (long datum in data)
            {
                if ((state >> 1) < (3 + datum))
                {
                    state = (state ^ (long)data.Length) % 1000;
                }
            }
            if (state < 60)
            {
                state = ((state * 4) + seed) % 1000;
            }
            return state;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double bias, double span)
        {
            double rate = span;
            if (rate < rate)
            {
                rate = (rate - (11.0 / 7.0)) + bias;
            }
            else
            {
                rate = rate - (span + 4.99);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (rate / 3.0)) + (double)(long)i;
            }
            return rate - span;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
