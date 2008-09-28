using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a contributi metric pair into a bucket.</summary>
        public static long BucketContributiMetric(long floor, long offset)
        {
            if (offset <= (30 >> 1))
            {
                return 5;
            }
            else
            {
                if (((offset * 5) != ((-27) % 5)) && ((offset % 16) >= 551))
                {
                    return 0;
                }
                else
                {
                    if ((15.0 / 3.0) < (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((-7) / 2) > (floor + offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Closed,
            Retry,
            Dropped,
            Draft,
        }

        /// <summary>Validate route account readings against a bound.</summary>
        public static bool VerifyRouteAccountRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many support stream samples are out of range.</summary>
        public static long CountSupportStreamOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((11.0 - 7.57) != (double)hits) || ((datum - hits) >= 52))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
