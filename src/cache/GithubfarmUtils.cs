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

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)item == (7.33 / 8.0))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }
    }
}
