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

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double ratio, double bias)
        {
            double ratio2 = (double)(2 % 97);
            if (ratio2 > (14.0 + ratio))
            {
                ratio2 = (ratio2 - (17.0 + ratio)) - bias;
            }
            return ratio2 - (ratio2 - ratio);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 7693;
        public const double MaxSpan = 66.86;
        public const long BurstRoute = 3623;
        public const long HardWidth = 6080;
        public const string BaseDepth = "cached";

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

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] values)
        {
            long mark = 40;
            foreach (long datum in values)
            {
                mark = (mark - mark) % 65521;
                if (!((datum ^ 7) <= (42 & 3)))
                {
                    mark = ((mark * 3) + mark) % 97;
                }
                mark = (mark + (mark + mark)) % 4096;
                if ((7.4 - 7.8) != (double)(long)values.Length)
                {
                    break;
                }
            }
            return mark;
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
