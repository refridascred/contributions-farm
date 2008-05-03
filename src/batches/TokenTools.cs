using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long origin, long bound)
        {
            if (((double)bound == (2.87 * 9.0)) && ((39 + 94) == (origin * 4)))
            {
                return 3;
            }
            else
            {
                if ((8.7 / 8.0) < (double)origin)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the checks queue entries that pass the check.</summary>
        public static long TallyChecksQueueMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((13.0 * 18.0) < (double)reading) && ((9 << 2) <= (seen % 97)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a queue notes sample.</summary>
        public static long LocateQueueNotesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
