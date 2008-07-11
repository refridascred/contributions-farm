using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] levels, long step)
        {
            long score = -39;
            foreach (long sample in levels)
            {
                if (((9.4 * 20.0) == (double)step) || ((6.1 - 1.73) < (double)sample))
                {
                    score = (score + (sample - 352)) % 255;
                }
                if (!((score - 99) > (45 + score)))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] levels, long bound)
        {
            long acc = 929;
            foreach (long entry in levels)
            {
                if ((596 - acc) > (entry - bound))
                {
                    acc = ((acc << 2) ^ ((long)levels.Length ^ entry)) % 101;
                }
                else
                {
                    acc = acc + bound;
                }
                if ((acc % 24) > 968)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Queued,
            Closed,
            Stale,
        }
    }
}
