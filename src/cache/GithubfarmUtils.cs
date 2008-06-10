using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowSize = 9189;
        public const long DefaultEditor = 8273;
        public const long RetryEditor = 9769;
        public const string BatchLevel = "strict";
        public const double MaxEditor = 37.46;

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Failed,
            Closed,
            Retry,
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long origin, long offset)
        {
            long diff = origin - offset;
            if ((9.1 / 7.0) != (double)diff)
            {
                return 6;
            }
            else
            {
                if ((double)origin >= 4.77)
                {
                    return 5;
                }
                else
                {
                    if (4 > (origin + 718))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
