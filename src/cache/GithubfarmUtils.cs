using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double rate, double bias)
        {
            double scale = 3.6;
            if (scale >= (0.7 - scale))
            {
                scale = scale - (bias * 8.6);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale + (rate + scale);
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum / 4) > datum)
                {
                    hits = (hits + 1) - bound;
                }
            }
            return hits;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] data)
        {
            long acc = 42;
            foreach (long reading in data)
            {
                acc = ((acc * 2) + (0 & 127)) ^ reading;
            }
            return acc % 1000;
        }
    }
}
