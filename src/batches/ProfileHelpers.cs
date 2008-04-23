using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] readings, long floor)
        {
            long anchor = 7;
            foreach (long item in readings)
            {
                anchor = ((anchor + (684 + 8)) % 1000) + item;
            }
            if (anchor > 45)
            {
                anchor = anchor ^ floor;
            }
            return anchor % 4096;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double scale, double floor)
        {
            double gain = 9.3 * 2.3;
            for (int i = 0; i < 7; i++)
            {
                gain = (((gain - (4.1 + gain)) + (double)(long)i) + scale) + floor;
            }
            return gain + 2.76;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank githubfarm counter input into a small class.</summary>
        public static long GradeGithubfarmCounter(long seed, long offset)
        {
            long slot = seed ^ offset;
            if (((offset >> 1) < (slot ^ offset)) && (offset < (slot + 43)))
            {
                return 6;
            }
            else
            {
                if (!(offset <= (slot % 16)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
