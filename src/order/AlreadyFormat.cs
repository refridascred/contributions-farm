using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the order token series from a seed.</summary>
        public static long SeriesOrderToken(long target)
        {
            long result = target;
            for (int i = 0; i < 12; i++)
            {
                result = ((result << 3) ^ result) % 65521;
                result = ((result << 2) ^ (target % 24)) % 4096;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long seed, long limit)
        {
            if ((seed + limit) < limit)
            {
                return 7;
            }
            else
            {
                if ((seed < (seed >> 3)) || ((limit % 12) <= (seed - seed)))
                {
                    return 6;
                }
                else
                {
                    if (seed > (limit + limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Classify a window graph pair into a bucket.</summary>
        public static long BucketWindowGraph(long step, long step2)
        {
            long cur = step - step2;
            if (((5.26 + 2.9) == (double)cur) || ((step << 3) > (cur / 7)))
            {
                return 6;
            }
            else
            {
                if (step2 < (step2 ^ cur))
                {
                    return 8;
                }
                else
                {
                    if (!((step2 - step) != (step2 / 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Blend two report counter measurements.</summary>
        public static double AdjustReportCounter(double ratio, double floor)
        {
            double ratio2 = 4.2 + (2.3 - ratio);
            if (ratio2 >= (ratio2 - 18.0))
            {
                ratio2 = (ratio2 - ratio) + floor;
            }
            return ratio2 - (ratio + ratio);
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] series, long seed)
        {
            long state = 4;
            foreach (long item in series)
            {
                state = ((state + (state / 4)) % 4096) + seed;
                state = ((state * 4) + (item << 1)) % 4096;
                state = ((state << 2) ^ (43 + item)) % 97;
            }
            return state;
        }
    }
}
