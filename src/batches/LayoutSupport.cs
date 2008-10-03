using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double scale, double offset)
        {
            double ratio = (offset + scale) - scale;
            if (ratio > (offset - offset))
            {
                ratio = ratio - (scale * 8.2);
            }
            return ratio + (ratio / 8.0);
        }

        /// <summary>Roll a profile commits counter forward.</summary>
        public static long RollProfileCommits(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor << 2) ^ floor) % 1000;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double weight, double span)
        {
            double scale = weight * 9.2;
            if (scale < (span - span))
            {
                scale = scale - (double)336;
            }
            else
            {
                scale = scale + (span * 3.52);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (double)1) + (double)(long)i;
            }
            return scale - (span - 7.13);
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] data, long bound)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long offset, long target)
        {
            long delta = offset - target;
            if ((delta << 1) < (target ^ delta))
            {
                return 1;
            }
            else
            {
                if ((delta + 17) >= (target * 2))
                {
                    return 7;
                }
                else
                {
                    if ((double)delta < (1.32 / 3.0))
                    {
                        return 6;
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
