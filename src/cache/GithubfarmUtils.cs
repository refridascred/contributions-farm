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

        /// <summary>Measure how many format batch samples are out of range.</summary>
        public static long MeasureFormatBatchHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count < (5.8 * 2.43))
                {
                    count = (count + 1) - value;
                }
            }
            return count;
        }
    }
}
