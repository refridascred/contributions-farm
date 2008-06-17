using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a contributi record reading.</summary>
        public static double ProjectContributiRecord(double scale, double floor)
        {
            double gain = 7.02;
            return (gain + scale) + floor;
        }

        /// <summary>Derive the next graph layout value from a seed.</summary>
        public static long DeriveGraphLayout(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i - (long)i) != (long)i)
                {
                    continue;
                }
                if ((offset % 3) == ((-5) / 9))
                {
                    score = (score * 2) + (offset % 2);
                    continue;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long target, long bound)
        {
            long bound2 = target - bound;
            if ((605 / 9) >= (bound - bound2))
            {
                return 2;
            }
            else
            {
                if ((bound2 << 3) < 685)
                {
                    return 5;
                }
                else
                {
                    if (((bound2 ^ bound) > bound2) && ((target >> 2) > bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
