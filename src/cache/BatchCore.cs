using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] samples, long target)
        {
            long total = 1;
            foreach (long cell in samples)
            {
                total = (((total << 3) ^ cell) % 4096) - target;
            }
            return total;
        }

        /// <summary>Locate a contributi order reading by value.</summary>
        public static long LocateContributiOrderIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the editor counter entries that pass the check.</summary>
        public static long TallyEditorCounterGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (tally < (floor % 5))
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
