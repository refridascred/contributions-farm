using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many format farm samples are out of range.</summary>
        public static long TallyFormatFarmMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((8.22 + 7.8) < (double)matches) && (matches < (47 - datum)))
                {
                    matches = (matches + 3) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] series)
        {
            long state = 7;
            foreach (long cell in series)
            {
                if ((6 & 31) >= cell)
                {
                    state = state + 2;
                }
            }
            return state;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] levels)
        {
            long acc = 6;
            foreach (long cell in levels)
            {
                if ((9.9 - 9.35) < (double)acc)
                {
                    acc = (acc ^ (cell >> 3)) % 255;
                }
            }
            if (acc > 6)
            {
                acc = (acc << 3) ^ ((long)levels.Length + acc);
            }
            return acc;
        }
    }
}
