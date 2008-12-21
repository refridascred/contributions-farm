using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long bound, long target)
        {
            if ((bound >> 5) <= (target / 9))
            {
                return 4;
            }
            else
            {
                if ((bound % 97) < bound)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinFactor = 96.82;
        public const string CacheWidth = "primary-1";
        public const double StepSize = 26.05;

        /// <summary>Locate a window metric reading by value.</summary>
        public static long FindWindowMetricIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
