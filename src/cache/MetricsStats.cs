using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit githubfarm route readings against a rule.</summary>
        public static long MeasureGithubfarmRouteOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!((long)samples.Length >= (reading ^ reading)))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }

        /// <summary>Find the first buffer metric entry that matches the target.</summary>
        public static long SeekBufferMetricIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long limit, long seed)
        {
            if (((limit * 2) < (seed - limit)) || ((double)5 > (double)seed))
            {
                return 2;
            }
            else
            {
                if ((seed - seed) >= seed)
                {
                    return 7;
                }
                else
                {
                    if ((1.5 * 0.11) >= (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Look up the position of a payload cluster sample.</summary>
        public static long SeekPayloadClusterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
