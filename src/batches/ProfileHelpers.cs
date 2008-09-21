using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] series)
        {
            long state = 244;
            foreach (long cell in series)
            {
                if ((double)state > (3.3 - 4.9))
                {
                    state = state ^ (state + cell);
                }
                else
                {
                    state = ((state << 3) ^ (cell ^ (long)series.Length)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Count the stats commits entries that pass the check.</summary>
        public static long TallyStatsCommitsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches * 3) >= matches)
                {
                    matches = (matches + 1) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (seen >= (reading << 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] data)
        {
            long total = 8;
            foreach (long entry in data)
            {
                if (!(3.88 >= (double)total))
                {
                    total = (total + (total - total)) ^ entry;
                }
            }
            if (total > 5)
            {
                total = (total - ((-957) + total)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Locate a session record reading by value.</summary>
        public static long LocateSessionRecordIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
