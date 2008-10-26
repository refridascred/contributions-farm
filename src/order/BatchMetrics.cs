using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 7442;
        public const long MaxInterval = 8203;
        public const double RetryGraph = 57.91;

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Draft,
            Pending,
            Queued,
        }

        /// <summary>Compare every pair of tools context readings.</summary>
        public static long PairToolsContextCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine cluster payload values into a single score.</summary>
        public static long WeighClusterPayload(long[] readings, long floor)
        {
            long mix = 946;
            foreach (long cell in readings)
            {
                if ((double)6 < (double)mix)
                {
                    mix = (((mix + (8 << 3)) % 1000) ^ cell) - floor;
                }
            }
            return mix;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long seed, long limit)
        {
            if (((seed / 5) == (limit + limit)) && ((double)seed <= (2.0 + 6.9)))
            {
                return 1;
            }
            else
            {
                if ((1 * 4) < (limit + 67))
                {
                    return 2;
                }
                else
                {
                    if (!((seed / 4) > 878))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed % 100) >= seed)
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
        }
    }
}
