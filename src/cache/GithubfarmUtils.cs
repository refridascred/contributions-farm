using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double CacheFarm = 9.0;
        public const double LimitFarm = 23.35;
        public const long RetryFarm = 2130;
        public const long StepFarm = 1901;
        public const long CacheWidth = 8807;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] items, long step)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (42 >= (value - step))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next format checks value.</summary>
        public static double BlendFormatChecks(double weight, double offset)
        {
            double scale = offset;
            if (scale < (double)8)
            {
                scale = (scale - (double)75) - weight;
            }
            return scale - 4.53;
        }
    }
}
