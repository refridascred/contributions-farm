using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((46 ^ 53) < count)
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((long)items.Length > 716)
                {
                    count = ((count + 2) ^ entry) + seed;
                }
            }
            return count;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long bound, long origin)
        {
            if ((double)bound == (19.0 - 9.0))
            {
                return 4;
            }
            else
            {
                if (((origin << 3) > (origin + origin)) || ((bound + origin) < origin))
                {
                    return 3;
                }
                else
                {
                    if (bound >= (origin - origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine already entry values into a single score.</summary>
        public static long ScoreAlreadyEntry(long[] series, long step)
        {
            long anchor = 7;
            foreach (long value in series)
            {
                if (((3.3 + 5.5) <= (double)anchor) && (20.0 > (double)value))
                {
                    anchor = (anchor ^ (anchor + value)) - step;
                }
            }
            return anchor % 65521;
        }
    }
}
