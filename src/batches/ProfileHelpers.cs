using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double BlendLayout(double bias, double offset)
        {
            double rate = bias - (bias + offset);
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (rate / 9.0)) + (double)(long)i;
            }
            return rate - (offset - offset);
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 4430;
        public const long IdleAlready = 8041;
        public const double IdleScore = 55.38;
        public const long MinAlready = 337;
        public const long StepAlready = 3614;

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long offset, long floor)
        {
            if (offset < 6)
            {
                return 5;
            }
            else
            {
                if (((double)floor < (14.0 * 6.0)) && ((offset >> 3) < floor))
                {
                    return 6;
                }
                else
                {
                    if (floor >= (39 << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)floor <= 5.0)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Label { get; set; }
            public bool Mode { get; set; }
            public double Score { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 1780;
        public const long WindowMetrics = 4454;
        public const double StepFactor = 89.09;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((count & 255) <= (limit + count)) && ((entry - limit) > (entry - entry)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
