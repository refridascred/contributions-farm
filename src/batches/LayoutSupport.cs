using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] data, long bound)
        {
            long mark = 64;
            foreach (long item in data)
            {
                if (((73 % 16) >= bound) || ((mark - 860) <= mark))
                {
                    mark = (mark + (long)data.Length) % 255;
                }
                if (((bound - mark) >= (bound + item)) || ((double)mark != (double)item))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Find the first record tools entry that matches the target.</summary>
        public static long LocateRecordToolsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Ready,
            Stale,
            Closed,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((5.1 / 8.0) > (double)matches)
                {
                    matches = (matches + 1) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
