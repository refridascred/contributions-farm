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

        /// <summary>Measure how many profile entry samples are out of range.</summary>
        public static long MeasureProfileEntryOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (8 > (entry - entry))
                {
                    matches = (matches + 2) + origin;
                }
            }
            return matches;
        }
    }
}
