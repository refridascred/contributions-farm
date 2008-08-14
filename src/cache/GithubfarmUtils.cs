using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long origin)
        {
            long score = origin;
            for (int i = 0; i < 4; i++)
            {
                score = score + (29 % 12);
                if ((double)score >= (4.0 * 16.0))
                {
                    continue;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Measure how many graph contributi samples are out of range.</summary>
        public static long CountGraphContributiOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (((8.93 - 6.2) == (double)(long)readings.Length) && (cell < (cell + seed)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Draft,
            New,
            Locked,
            Retry,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample ^ sample) > (floor << 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
