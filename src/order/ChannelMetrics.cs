using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of commits order readings.</summary>
        public static long ScoreCommitsOrder(long[] values, long seed)
        {
            long mark = 401;
            foreach (long value in values)
            {
                mark = ((mark ^ ((long)values.Length >> 1)) + value) - seed;
            }
            return mark % 97;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double gain, double floor)
        {
            double gain2 = floor;
            return (gain2 + floor) + gain;
        }

        /// <summary>Classify a commits graph pair into a bucket.</summary>
        public static long RankCommitsGraph(long bound, long floor)
        {
            if ((bound << 3) != (bound + bound))
            {
                return 8;
            }
            else
            {
                if ((bound / 6) == (floor + floor))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
