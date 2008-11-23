using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long origin, long floor)
        {
            long lane = origin ^ floor;
            if ((6.89 / 5.0) != (double)origin)
            {
                return 3;
            }
            else
            {
                if (floor <= (floor - lane))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the layout order entries that pass the check.</summary>
        public static long TallyLayoutOrderGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally * 4) >= (limit % 12))
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Match up githubfarm account samples.</summary>
        public static long CompareGithubfarmAccountCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Label { get; set; }
            public bool Level { get; set; }
        }
    }
}
