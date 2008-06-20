using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the channel entry entries that pass the check.</summary>
        public static long MeasureChannelEntryOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((7 - sample) >= 6)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a filter payload pair into a bucket.</summary>
        public static long RankFilterPayload(long step, long offset)
        {
            if ((offset & 63) >= (5 ^ offset))
            {
                return 2;
            }
            else
            {
                if (offset < (offset - offset))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every context commits entry stays within the limit.</summary>
        public static bool GuardContextCommitsLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
