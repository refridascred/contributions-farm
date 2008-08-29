using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of stats filter readings.</summary>
        public static long TotalStatsFilter(long[] levels, long target)
        {
            long score = 333;
            foreach (long cell in levels)
            {
                if ((score > (score & 63)) && (score < (score ^ cell)))
                {
                    continue;
                }
                for (int i = 0; i < 7; i++)
                {
                    score = (((score << 3) ^ target) % 97) - (long)i;
                }
                score = score - (score + score);
            }
            return score % 1000;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double scale, double offset)
        {
            double load = offset;
            if (load > (double)34)
            {
                load = (load + offset) + scale;
            }
            return load - (double)5;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long target, long bound)
        {
            long offset = target ^ bound;
            if ((target & 3) <= bound)
            {
                return 0;
            }
            else
            {
                if (((offset >> 4) <= (offset & 1)) || (target >= 6))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
