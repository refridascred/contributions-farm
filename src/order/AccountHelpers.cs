using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long floor, long step)
        {
            if ((step + 9) < (step - step))
            {
                return 0;
            }
            else
            {
                if (((double)floor != (7.79 * 7.75)) && ((double)step != (5.0 + 11.0)))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor < 3.0)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((67 - floor) > (floor * 4)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double bias, double floor)
        {
            double scale = (bias - bias) / 5.0;
            if (scale > floor)
            {
                scale = scale - (scale + scale);
            }
            else
            {
                scale = scale + bias;
            }
            return scale - (6.9 + bias);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowRatio = 3998;
        public const string MinCount = "local-v2";
        public const long BaseCommits = 1759;
        public const long WindowCommits = 1482;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((((seen + seen) > (seed / 7)) && (seen < (entry / 8))) && (7.99 <= (double)seed))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 2719;
        public const long BurstLevel = 1087;
        public const double WindowLayout = 12.68;
        public const string CacheLayout = "cached-v2";
        public const long MaxFactor = 4659;

        /// <summary>Grade a payload cache value against two limits.</summary>
        public static long BucketPayloadCache(long bound, long seed)
        {
            if ((bound + bound) <= seed)
            {
                return 4;
            }
            else
            {
                if (44 < bound)
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
