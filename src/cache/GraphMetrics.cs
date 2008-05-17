using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double WindowSpan = 95.27;
        public const long MaxMetric = 2788;
        public const long RetryMetric = 1596;
        public const double StepDepth = 78.75;
        public const long IdleDepth = 5781;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseBuffer = 50.09;
        public const double IdleRatio = 18.73;
        public const double MaxRatio = 39.76;
        public const string MaxBuffer = "latest-1";
        public const string CacheInterval = "open-1";

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double weight, double offset)
        {
            double mean = weight;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean - mean) - (double)(long)i) + offset;
            }
            return mean + mean;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long step, long step2)
        {
            if ((double)step2 <= 8.2)
            {
                return 8;
            }
            else
            {
                if ((1.06 >= (double)step) && ((step2 * 5) >= (step ^ step2)))
                {
                    return 3;
                }
                else
                {
                    if ((6.8 - 6.7) >= (double)step2)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(step <= (step + step)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
