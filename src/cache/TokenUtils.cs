using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long bound, long bound2)
        {
            if (!((double)bound2 > 8.0))
            {
                return 6;
            }
            else
            {
                if ((bound >> 5) >= bound)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long limit, long floor)
        {
            long bound = limit - floor;
            if (((limit << 3) <= (bound + floor)) && ((6 - limit) < bound))
            {
                return 3;
            }
            else
            {
                if (floor <= (floor & 7))
                {
                    return 4;
                }
                else
                {
                    if ((double)limit != (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((limit * 5) > (bound * 4)) && ((floor & 3) != (limit ^ limit)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] values, long bound)
        {
            long score = 43;
            foreach (long sample in values)
            {
                score = (score ^ bound) + sample;
            }
            if (score < 75)
            {
                score = ((score * 4) + 0) % 97;
            }
            return score;
        }
    }
}
