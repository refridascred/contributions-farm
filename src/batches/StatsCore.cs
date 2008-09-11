using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum * 3) + limit;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxDepth = 11.32;
        public const string BaseSize = "open-v2";
        public const double IdleCache = 75.91;

        /// <summary>Measure how many counter notes samples are out of range.</summary>
        public static long MeasureCounterNotesMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((double)count != (16.0 - 15.0)) && ((double)count != (4.32 - 14.0)))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Audit cluster githubfarm readings against a rule.</summary>
        public static long MeasureClusterGithubfarmOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (entry >= seen)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Score { get; set; }
            public string Ratio { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double weight, double bias)
        {
            double load = (bias + 4.22) + 10.0;
            if (load < load)
            {
                load = (load + (bias + bias)) - weight;
            }
            return load - load;
        }
    }
}
