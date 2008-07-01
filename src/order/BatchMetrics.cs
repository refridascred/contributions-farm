using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many schema githubfarm samples are out of range.</summary>
        public static long MeasureSchemaGithubfarmMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((2 ^ offset) < ((long)data.Length >> 2))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Classify a entry githubfarm pair into a bucket.</summary>
        public static long BucketEntryGithubfarm(long bound, long step)
        {
            if ((bound & 15) < bound)
            {
                return 6;
            }
            else
            {
                if (((step << 1) < (step / 8)) || ((step % 3) <= (1 + (-36))))
                {
                    return 4;
                }
                else
                {
                    if ((((-52) & 255) >= (bound - step)) || ((bound ^ bound) < (bound / 7)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound / 9) != (bound ^ bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstMetrics = "local";
        public const long BaseMetrics = 2236;
        public const string MaxDepth = "local-v2";

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Draft,
            Ready,
            Closed,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((count % 64) > sample) && ((double)sample > (9.7 - 20.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
