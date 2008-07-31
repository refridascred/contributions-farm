using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseScore = "standard-1";
        public const string BaseInterval = "legacy";
        public const double MaxMetrics = 75.37;

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((((double)reading > 4.0) && (9.83 > (double)matches)) || ((double)reading >= (2.9 + 2.2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((3 * 4) != (count << 1)))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Adjust a checks window reading.</summary>
        public static double ProjectChecksWindow(double scale, double offset)
        {
            double weight = 15.0;
            if (weight >= (scale * 5.1))
            {
                weight = (weight + (double)9) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (weight - weight)) - (double)(long)i;
            }
            return weight + (scale / 2.0);
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long origin, long limit)
        {
            if (((origin ^ limit) >= (origin % 3)) && ((5.63 * 16.0) >= (double)origin))
            {
                return 7;
            }
            else
            {
                if ((limit + origin) >= 86)
                {
                    return 5;
                }
                else
                {
                    if ((double)origin == (9.6 + 19.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] readings, long origin)
        {
            long acc = 28;
            foreach (long value in readings)
            {
                acc = (((acc << 3) ^ (origin >> 2)) % 65521) ^ value;
            }
            return acc % 65521;
        }
    }
}
