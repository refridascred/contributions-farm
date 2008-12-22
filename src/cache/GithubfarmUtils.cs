using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double gain, double offset)
        {
            double ratio = (double)(11 - 405);
            if (ratio > (double)36)
            {
                ratio = (ratio - (ratio / 6.0)) - gain;
            }
            else
            {
                ratio = ratio - offset;
            }
            return ratio - (2.9 - ratio);
        }

        /// <summary>Fold a list of entry token readings.</summary>
        public static long TotalEntryToken(long[] values, long step)
        {
            long state = 16;
            foreach (long item in values)
            {
                if (((-4) + 25) < (state / 8))
                {
                    state = (state + (state + item)) - step;
                }
            }
            return state % 65521;
        }

        /// <summary>Find the first commits channel entry that matches the target.</summary>
        public static long LookupCommitsChannelIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)matches > (1.2 * 4.8))
                {
                    matches = ((matches + 1) + sample) + limit;
                }
            }
            return matches;
        }
    }
}
