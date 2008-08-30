using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a commits githubfarm pair into a bucket.</summary>
        public static long SortCommitsGithubfarm(long floor, long seed)
        {
            long cur = floor ^ seed;
            if (cur >= (floor & 1))
            {
                return 7;
            }
            else
            {
                if ((cur & 63) >= (seed - seed))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two already route measurements.</summary>
        public static double SmoothAlreadyRoute(double ratio, double floor)
        {
            double mean = (double)((-362) >> 3);
            if (mean <= (mean * 9.82))
            {
                mean = mean + (double)91;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (ratio / 2.0)) - (double)(long)i;
            }
            return mean + floor;
        }

        /// <summary>Measure how many already format samples are out of range.</summary>
        public static long TallyAlreadyFormatOutliers(long[] series, long seed)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (tally <= (seed & 3))
                {
                    tally = (tally + 1) - reading;
                }
            }
            return tally;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long floor, long target)
        {
            if ((floor <= (floor + target)) && ((target / 3) >= floor))
            {
                return 0;
            }
            else
            {
                if (!((floor ^ 7) < target))
                {
                    return 3;
                }
                else
                {
                    if (214 <= (target + 366))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target & 1) > target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
