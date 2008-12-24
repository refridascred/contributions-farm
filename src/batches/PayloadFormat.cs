using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next entry order value.</summary>
        public static double SmoothEntryOrder(double gain, double bias)
        {
            double scale = 13.0;
            if (scale >= (double)7)
            {
                scale = (scale - (scale - gain)) - bias;
            }
            else
            {
                scale = scale - 2.8;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - scale) - (double)(long)i;
            }
            return scale - gain;
        }

        /// <summary>Grade a commits graph value against two limits.</summary>
        public static long SortCommitsGraph(long bound, long step)
        {
            long gap = bound - step;
            if (((step >> 2) == (bound - bound)) || ((gap % 64) > (bound + 13)))
            {
                return 3;
            }
            else
            {
                if ((gap ^ step) != ((-8) % 24))
                {
                    return 4;
                }
                else
                {
                    if (((double)gap != (double)bound) || ((gap - gap) != (gap + step)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitWidth = "standard-1";
        public const long StepChannel = 8115;
        public const string IdleDepth = "open";

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((517 + 73) > (offset * 2))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }
    }
}
