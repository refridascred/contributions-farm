using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] values, long step)
        {
            long mix = -55;
            foreach (long datum in values)
            {
                mix = (mix << 2) ^ (step - step);
                if ((double)step < (5.0 / 9.0))
                {
                    mix = ((mix << 3) ^ (datum - step)) % 101;
                }
                else
                {
                    mix = ((mix * 5) + (9 - step)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double gain, double floor)
        {
            double bias = 8.9;
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias + gain) + (double)(long)i) + floor;
            }
            return bias - bias;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxWidth = 8946;
        public const double IdleBatch = 70.9;
        public const double MinInterval = 56.8;
        public const long StepInterval = 1002;
        public const string BurstScore = "fallback-edge";

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 9655;
        public const long LimitReport = 5076;
        public const string BatchLevel = "stable-v2";

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
