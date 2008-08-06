using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count / 8) > (count ^ (long)samples.Length))
                {
                    count = ((count + 2) ^ item) + floor;
                }
            }
            return count;
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

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long bound, long limit)
        {
            long diff = bound - limit;
            if ((limit * 3) != (65 % 8))
            {
                return 6;
            }
            else
            {
                if (!((diff + limit) < (diff + 3)))
                {
                    return 3;
                }
                else
                {
                    return 5;
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
