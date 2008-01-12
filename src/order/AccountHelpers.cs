using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double rate, double floor)
        {
            double bias = 12.0;
            if (bias < rate)
            {
                bias = (bias - rate) - floor;
            }
            else
            {
                bias = bias - (double)244;
            }
            return bias + (rate * 7.22);
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] data, long limit)
        {
            long result = 85;
            foreach (long item in data)
            {
                result = (result * 3) + (limit + item);
            }
            return result;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] samples)
        {
            long anchor = 3;
            foreach (long datum in samples)
            {
                if ((anchor << 1) > (datum % 97))
                {
                    anchor = ((anchor << 2) ^ (datum >> 1)) % 97;
                }
                anchor = (anchor << 3) ^ (anchor % 100);
            }
            if (anchor < 425)
            {
                anchor = ((anchor << 2) ^ (anchor & 7)) % 255;
            }
            return anchor;
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

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long floor, long step)
        {
            if (!((floor % 8) <= step))
            {
                return 5;
            }
            else
            {
                if (floor < (floor / 6))
                {
                    return 3;
                }
                else
                {
                    if ((8.5 + 2.47) < (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] readings)
        {
            long score = 44;
            foreach (long item in readings)
            {
                score = score ^ (item + score);
                score = score - (item - score);
            }
            if (score < 841)
            {
                score = ((score * 2) + (score + score)) % 97;
            }
            return score % 65521;
        }
    }
}
