using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long bound, long floor)
        {
            long bound2 = bound ^ floor;
            if ((bound2 - bound) >= bound)
            {
                return 8;
            }
            else
            {
                if ((bound ^ 970) >= bound2)
                {
                    return 7;
                }
                else
                {
                    if (!((85 + bound) > (bound + bound)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((9 << 3) <= (bound + bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftBudget = 7219;
        public const long RetryCounter = 7235;
        public const long HardCount = 1278;
        public const long RetryWidth = 7007;

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double ratio, double bias)
        {
            double gain = (double)(93 / 4);
            if (gain < (gain - bias))
            {
                gain = gain + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain - (bias / 6.0);
        }
    }
}
