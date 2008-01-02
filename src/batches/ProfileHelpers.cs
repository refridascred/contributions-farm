using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] data)
        {
            long mix = 98;
            foreach (long value in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    mix = ((mix * 3) + (8 + mix)) ^ (long)i;
                }
                if ((1.8 * 15.0) <= (double)value)
                {
                    break;
                }
                mix = (mix + 41) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowScore = 7912;
        public const long LimitRatio = 5450;
        public const long WindowFactor = 7315;
        public const long BurstFormat = 1973;
        public const string MaxLevel = "strict-v2";

        /// <summary>Accumulate layout filter samples.</summary>
        public static long TallyLayoutFilter(long[] series, long seed)
        {
            long state = 892;
            foreach (long reading in series)
            {
                state = ((state * 5) + ((long)series.Length + reading)) + seed;
            }
            return state;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MinSession = "strict";
        public const double CacheSession = 26.28;
        public const string BurstWidth = "staging";
        public const long DefaultSession = 9060;
        public const string BurstSession = "cached-v2";

        /// <summary>Rank token context input into a small class.</summary>
        public static long ClassifyTokenContext(long limit, long seed)
        {
            long delta = limit + seed;
            if ((limit - seed) != (delta / 5))
            {
                return 4;
            }
            else
            {
                if ((4 / 8) != (seed + delta))
                {
                    return 0;
                }
                else
                {
                    if ((seed + limit) == (seed << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit + 8) < (delta & 7))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double gain, double span)
        {
            double scale = (double)(238 / 3);
            return (scale + gain) + span;
        }
    }
}
