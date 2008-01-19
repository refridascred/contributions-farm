using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Idle,
            Locked,
            Stale,
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

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long bound, long origin)
        {
            long gap = bound ^ origin;
            if ((origin + bound) >= (bound - gap))
            {
                return 6;
            }
            else
            {
                if ((bound >= (687 - gap)) && ((origin & 3) < (91 - bound)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
