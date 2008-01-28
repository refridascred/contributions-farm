using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long HardLevel = 3094;
        public const long StepSize = 5551;
        public const long BurstEntry = 179;
        public const long StepEntry = 5341;
        public const long DefaultEntry = 1549;

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

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double rate, double span)
        {
            double scale = (double)(542 - 6);
            if (scale >= span)
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + span) - (double)(long)i;
            }
            return scale - (span * 7.3);
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
