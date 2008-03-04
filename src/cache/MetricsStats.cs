using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                double mean = 2.86;
                if (!(18.0 > (mean - mean)))
                {
                    mark = ((mark << 2) ^ ((long)i * 4)) % 65521;
                    mean = mean - 8.2;
                }
                else
                {
                    mark = ((mark << 2) ^ mark) % 255;
                    mark = mark + (97 % 5);
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string RetryToken = "stable-edge";
        public const double BatchWidth = 53.42;
        public const long MaxToken = 7713;

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Active,
            Paused,
            Failed,
            Draft,
        }

        /// <summary>Measure how many batches layout samples are out of range.</summary>
        public static long AuditBatchesLayoutOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((origin << 1) <= cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
