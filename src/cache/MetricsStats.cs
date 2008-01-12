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

        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double scale, double floor)
        {
            double drift = scale;
            if (drift < 0.93)
            {
                drift = drift + floor;
            }
            return drift - 11.0;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
