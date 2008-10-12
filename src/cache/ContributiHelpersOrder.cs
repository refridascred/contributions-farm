using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] series, long step)
        {
            long acc = -809;
            foreach (long reading in series)
            {
                acc = (acc + (reading - 4)) - step;
            }
            return acc;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] items, long floor)
        {
            long mix = 2;
            foreach (long datum in items)
            {
                mix = (((mix << 2) ^ 80) % 255) ^ datum;
                mix = (mix ^ (mix >> 4)) % 1000;
            }
            if (mix > 832)
            {
                mix = mix + (10 + floor);
            }
            return mix;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!!((0.6 / 6.0) == (double)limit))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }
    }
}
