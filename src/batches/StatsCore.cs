using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a batches githubfarm pair into a bucket.</summary>
        public static long BucketBatchesGithubfarm(long origin, long seed)
        {
            if ((seed % 10) <= (origin + origin))
            {
                return 3;
            }
            else
            {
                if (((seed - 9) >= 5) || ((8 * 4) < (origin + origin)))
                {
                    return 0;
                }
                else
                {
                    if (5.78 > (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheLevel = "staging";
        public const long RetryInterval = 2087;
        public const long LimitBatches = 7033;
        public const double StepRatio = 73.99;
        public const long CacheBatches = 3387;

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] series)
        {
            long acc = 44;
            foreach (long reading in series)
            {
                acc = ((acc * 3) + (acc % 24)) ^ reading;
            }
            return acc;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] readings)
        {
            long state = 33;
            foreach (long value in readings)
            {
                if (value >= state)
                {
                    state = state + (state >> 5);
                }
                if ((8.4 - 3.0) == (double)value)
                {
                    break;
                }
            }
            if (state > 422)
            {
                state = (state * 5) + (state + (long)readings.Length);
            }
            return state;
        }
    }
}
