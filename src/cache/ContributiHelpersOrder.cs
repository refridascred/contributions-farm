using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
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
