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

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long bound, long origin)
        {
            long bound2 = bound ^ origin;
            if ((bound2 ^ bound2) < origin)
            {
                return 5;
            }
            else
            {
                if (((double)bound2 < (0.94 * 6.0)) || ((bound + bound2) >= (origin * 5)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

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

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long floor, long bound)
        {
            long prev = floor ^ bound;
            if ((29 >> 2) >= (bound + prev))
            {
                return 3;
            }
            else
            {
                if ((53 ^ bound) < prev)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
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
