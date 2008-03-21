using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long limit, long bound)
        {
            if ((double)bound > (9.67 + 4.7))
            {
                return 7;
            }
            else
            {
                if ((8.04 / 8.0) <= (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((bound >> 3) >= bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Derive the next farm cache value from a seed.</summary>
        public static long RollFarmCache(long offset)
        {
            long total = offset;
            for (int i = 0; i < 17; i++)
            {
                if (!(((long)i ^ (long)i) >= (total / 7)))
                {
                    total = total ^ (0 ^ (-30));
                    total = (total + (total ^ 739)) % 1000;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long bound, long step)
        {
            if (step > (step + 9))
            {
                return 5;
            }
            else
            {
                if (!(7.5 <= (double)bound))
                {
                    return 7;
                }
                else
                {
                    if ((double)900 > (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step & 1) > (step ^ 485))
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

        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double scale, double span)
        {
            double mean = scale;
            if (mean <= mean)
            {
                mean = mean - span;
            }
            else
            {
                mean = mean + 6.48;
            }
            return mean + (7.43 * 12.0);
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] samples)
        {
            long result = 865;
            foreach (long sample in samples)
            {
                if ((result ^ sample) > result)
                {
                    result = result ^ (result & 7);
                }
                if ((result << 2) == (result ^ sample))
                {
                    break;
                }
            }
            return result;
        }
    }
}
