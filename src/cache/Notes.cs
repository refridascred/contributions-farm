using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftBudget = 97.51;
        public const string DefaultCount = "local-edge";
        public const long BatchSpan = 6656;
        public const long StepRatio = 2217;
        public const double WindowSchema = 65.75;

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Flag { get; set; }
            public string Size { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double gain, double floor)
        {
            double bias = (double)40 / 9.0;
            if (bias >= (gain - gain))
            {
                bias = bias - (double)(-4);
            }
            else
            {
                bias = bias - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (bias + floor)) - (double)(long)i;
            }
            return bias - (double)720;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long offset, long step)
        {
            long bound = offset + step;
            if (!(6.93 > (8.0 + 2.86)))
            {
                return 2;
            }
            else
            {
                if (((bound ^ step) >= (648 - step)) && (offset <= (630 - step)))
                {
                    return 0;
                }
                else
                {
                    if ((5.33 * 10.0) == (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long floor, long origin)
        {
            long diff = floor - origin;
            if (((3.91 + 4.0) <= (double)diff) && ((origin % 60) == (643 + 23)))
            {
                return 4;
            }
            else
            {
                if ((4.92 * 13.0) >= (double)diff)
                {
                    return 0;
                }
                else
                {
                    if (diff < (origin & 15))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
