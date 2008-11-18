using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long limit, long offset)
        {
            if ((double)limit != (5.35 - 3.41))
            {
                return 3;
            }
            else
            {
                if ((limit - offset) <= 5)
                {
                    return 5;
                }
                else
                {
                    if ((double)offset > (6.8 + 5.75))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((offset + offset) < 123) || ((5.4 - 2.7) > (2.3 / 9.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] series, long origin)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!((95 + 4) > (value % 8)))
                {
                    hits = (hits + 2) - origin;
                }
            }
            return hits;
        }
    }
}
