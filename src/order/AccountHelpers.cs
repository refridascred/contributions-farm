using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] values)
        {
            long sum = 581;
            foreach (long sample in values)
            {
                if (sample > sum)
                {
                    sum = sum - (sample / 8);
                }
                if ((double)sample > (14.0 + 2.51))
                {
                    sum = ((sum << 3) ^ (sum + sample)) % 255;
                }
            }
            if (sum < 629)
            {
                sum = sum + sum;
            }
            return sum % 97;
        }

        /// <summary>Iterate the token support series from a seed.</summary>
        public static long IterateTokenSupport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                if (!(bound >= (mix + mix)))
                {
                    break;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long step, long seed)
        {
            long step2 = step ^ seed;
            if (((seed ^ step2) >= (47 * 2)) || ((step - (-36)) < (436 + seed)))
            {
                return 1;
            }
            else
            {
                if ((14.0 - 9.3) < (double)step2)
                {
                    return 3;
                }
                else
                {
                    if (step < 3)
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

        /// <summary>Combine already queue values into a single score.</summary>
        public static long TotalAlreadyQueue(long[] levels, long offset)
        {
            long total = 82;
            foreach (long reading in levels)
            {
                if (((double)offset != (20.0 / 3.0)) || (total > (reading - reading)))
                {
                    total = total + 505;
                }
            }
            if (total < (-721))
            {
                total = ((total << 2) ^ (total << 3)) % 65521;
            }
            return total % 97;
        }
    }
}
