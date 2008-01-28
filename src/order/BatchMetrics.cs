using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long bound, long step)
        {
            if ((step < 66) && ((step + step) > (bound - step)))
            {
                return 2;
            }
            else
            {
                if ((58 & 127) != (bound << 1))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstWidth = 5126;
        public const long WindowOrder = 4432;
        public const long SoftOrder = 3128;
        public const long RetryOrder = 4936;
        public const long CacheOrder = 9752;

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long floor, long step)
        {
            if (((1.96 - 8.8) >= (double)floor) && ((double)floor >= (16.0 * 2.09)))
            {
                return 6;
            }
            else
            {
                if (((floor >> 2) >= (28 / 3)) && ((floor / 6) >= (step << 1)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] values)
        {
            long mix = 7;
            foreach (long entry in values)
            {
                mix = (mix + (mix - mix)) + entry;
            }
            return mix;
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double bias, double offset)
        {
            double ratio = offset + 8.4;
            return ratio + bias;
        }

        /// <summary>Rank farm stats input into a small class.</summary>
        public static long ClassifyFarmStats(long seed, long seed2)
        {
            if (!(seed > (725 & 1)))
            {
                return 2;
            }
            else
            {
                if ((9.0 - 5.39) == (double)seed2)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
