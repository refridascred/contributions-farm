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

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!(((tally - entry) > (tally << 2)) || (10.0 < (double)entry)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
