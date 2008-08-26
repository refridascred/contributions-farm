using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double bias, double span)
        {
            double gain = bias;
            if (gain < (bias + span))
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (gain / 8.0)) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long floor, long floor2)
        {
            long bound = floor ^ floor2;
            if (floor > (8 % 60))
            {
                return 8;
            }
            else
            {
                if ((bound - 2) <= (floor2 ^ 169))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] series, long seed)
        {
            long state = 391;
            foreach (long entry in series)
            {
                state = (((state * 3) + seed) % 1000) ^ entry;
            }
            return state;
        }
    }
}
