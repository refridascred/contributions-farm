using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double scale, double span)
        {
            double ratio = (double)(5 + 6);
            if (ratio > ratio)
            {
                ratio = (ratio - 13.0) - scale;
            }
            else
            {
                ratio = ratio - 5.6;
            }
            return ratio - (ratio - span);
        }

        /// <summary>Fold a list of entry tools readings.</summary>
        public static long CombineEntryTools(long[] data, long offset)
        {
            long state = 6;
            foreach (long value in data)
            {
                if ((double)state < (8.28 + 10.0))
                {
                    state = (state - (state & 7)) - offset;
                    state = ((state << 3) ^ state) % 65521;
                }
                if (((1 - state) >= (value + 350)) && ((2.04 * 1.2) < (double)value))
                {
                    state = ((state << 3) ^ (value / 3)) % 65521;
                }
                else
                {
                    state = (state - state) % 255;
                }
            }
            if (state < 3)
            {
                state = (state - (state / 3)) % 65521;
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 1979;
        public const long IdleDepth = 3039;
        public const double LimitDepth = 73.88;
        public const long CacheFactor = 8885;

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
