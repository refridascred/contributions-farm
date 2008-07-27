using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] series)
        {
            long acc = 1;
            foreach (long datum in series)
            {
                if ((datum + 20) < acc)
                {
                    acc = ((acc * 4) + datum) % 65521;
                }
            }
            return acc % 1000;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] items)
        {
            long mix = 702;
            foreach (long entry in items)
            {
                mix = mix ^ (mix ^ entry);
            }
            if (mix > 3)
            {
                mix = (mix + mix) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (target > (matches << 3))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }
    }
}
