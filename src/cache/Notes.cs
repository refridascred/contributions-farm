using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((matches & 255) < (-7)) || ((double)datum > 8.0))
                {
                    matches = (matches + 2) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 5953;
        public const long BaseSchema = 432;
        public const double SoftInterval = 16.66;
        public const string HardFactor = "latest";

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long target, long seed)
        {
            if ((double)target <= (9.0 / 3.0))
            {
                return 3;
            }
            else
            {
                if ((target ^ target) != (target - target))
                {
                    return 2;
                }
                else
                {
                    if ((target & 127) != (seed + seed))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long target, long limit)
        {
            long gap = target - limit;
            if ((target + limit) <= (target / 8))
            {
                return 0;
            }
            else
            {
                if (!((double)gap > (3.5 / 2.0)))
                {
                    return 8;
                }
                else
                {
                    if ((6.54 + 0.4) >= (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)target >= (4.3 / 9.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
