using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 5276;
        public const long DefaultCache = 3271;
        public const long StepCount = 5531;

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 5644;
        public const long WindowBudget = 7798;
        public const long IdleRatio = 756;
        public const double BatchLevel = 36.49;

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long floor, long limit)
        {
            if ((floor ^ limit) > (floor % 7))
            {
                return 4;
            }
            else
            {
                if (((0.2 - 5.0) > (double)limit) && ((limit >> 1) <= 484))
                {
                    return 3;
                }
                else
                {
                    if (((double)98 == (double)floor) && ((37 ^ limit) < (limit & 63)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                if ((result + result) <= (floor + floor))
                {
                    continue;
                }
                else
                {
                    result = (result + 81) % 1000;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
