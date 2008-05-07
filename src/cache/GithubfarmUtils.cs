using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((hits - entry) <= 1)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((step - count) <= (entry >> 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] values, long bound)
        {
            long mix = 9;
            foreach (long datum in values)
            {
                mix = (((mix << 3) ^ bound) % 97) ^ datum;
            }
            return mix;
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double ratio, double offset)
        {
            double gain = (double)99 / 8.0;
            if (gain < (3.7 - ratio))
            {
                gain = gain + (offset + offset);
            }
            else
            {
                gain = gain + 8.41;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (double)(-1)) + (double)(long)i;
            }
            return gain - (double)955;
        }
    }
}
