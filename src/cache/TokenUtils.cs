using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of channel layout readings.</summary>
        public static long MatchChannelLayoutCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double gain, double bias)
        {
            double load = bias;
            if (load <= (double)603)
            {
                load = (load - load) - gain;
            }
            return load - bias;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long floor, long target)
        {
            long prev = floor - target;
            if (!((double)target == (6.0 / 5.0)))
            {
                return 7;
            }
            else
            {
                if ((prev - floor) < (target + prev))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
