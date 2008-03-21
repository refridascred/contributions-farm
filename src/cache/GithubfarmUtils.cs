using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (32 < count)
                {
                    count = ((count + 2) + datum) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 8100;
        public const long IdleCluster = 9194;
        public const double LimitCluster = 74.99;
        public const double DefaultWidth = 91.6;
        public const long StepTimeout = 5240;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value + count) <= (value - limit))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] readings)
        {
            long mix = 36;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = (mix + (mix + reading)) ^ (long)i;
                }
                if (((41 >> 3) <= (reading << 2)) || (mix <= (reading + 60)))
                {
                    mix = ((mix << 3) ^ (mix & 1)) % 65521;
                }
            }
            return mix % 4096;
        }
    }
}
