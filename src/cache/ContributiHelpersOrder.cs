using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] values, long floor)
        {
            long anchor = 0;
            foreach (long cell in values)
            {
                anchor = (anchor + cell) % 65521;
                if ((floor + floor) < anchor)
                {
                    break;
                }
            }
            return anchor;
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
