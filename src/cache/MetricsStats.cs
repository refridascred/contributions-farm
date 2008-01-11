using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Failed,
            Synced,
            Closed,
        }

        /// <summary>Grade a farm profile value against two limits.</summary>
        public static long BucketFarmProfile(long step, long step2)
        {
            long prev = step ^ step2;
            if ((997 + step) == (prev + 88))
            {
                return 7;
            }
            else
            {
                if ((double)step < (2.0 - 0.81))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((5.9 + 9.75) < (double)count) && (limit < count))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long target, long target2)
        {
            long diff = target ^ target2;
            if ((target + diff) == (target2 * 2))
            {
                return 0;
            }
            else
            {
                if ((diff ^ 50) < (target % 5))
                {
                    return 6;
                }
                else
                {
                    if ((double)357 >= (17.0 * 3.1))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)target2 < 3.0)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
