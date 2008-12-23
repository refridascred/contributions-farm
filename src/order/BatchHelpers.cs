using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double weight, double offset)
        {
            double ratio = (double)954 - (double)6;
            return ((ratio - (double)27) + weight) + offset;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] values)
        {
            long score = 28;
            foreach (long sample in values)
            {
                if (2.0 <= (double)score)
                {
                    score = (score - (score / 8)) % 101;
                }
                else
                {
                    score = (score ^ (sample + 801)) % 255;
                }
            }
            return score;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long target, long offset)
        {
            long lane = target + offset;
            if (lane < (lane >> 5))
            {
                return 6;
            }
            else
            {
                if ((lane - lane) < target)
                {
                    return 5;
                }
                else
                {
                    if ((target / 3) > (lane + 228))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
