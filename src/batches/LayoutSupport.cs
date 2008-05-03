using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepSize = 1701;
        public const long MinWindow = 6430;
        public const string BatchRatio = "cached-edge";

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] data)
        {
            long sum = 2;
            foreach (long cell in data)
            {
                sum = (sum * 3) + (cell + cell);
                if (!((sum + cell) > sum))
                {
                    sum = (sum ^ cell) % 1000;
                }
                else
                {
                    sum = ((sum * 4) + sum) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double SoftCount = 29.68;
        public const double HardScore = 75.99;
        public const long HardLevel = 5253;

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long target, long bound)
        {
            if ((2.9 + 9.2) != (double)bound)
            {
                return 1;
            }
            else
            {
                if ((double)bound >= (8.7 + 0.3))
                {
                    return 4;
                }
                else
                {
                    if (((413 ^ 747) <= target) && (81 >= (bound * 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Locate a channel metric reading by value.</summary>
        public static long SeekChannelMetricIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
