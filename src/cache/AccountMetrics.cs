using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next cluster metrics value from a seed.</summary>
        public static long SeriesClusterMetrics(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 5; i++)
            {
                if (!((mix & 127) > (mix / 7)))
                {
                    mix = mix ^ (299 + mix);
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchCluster = "cached";
        public const string StepCluster = "staging-edge";
        public const double CacheInterval = 87.94;

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double weight, double span)
        {
            double mean = (double)(683 ^ 37);
            if (mean <= (5.3 - weight))
            {
                mean = mean + (3.3 + span);
            }
            return mean + (double)42;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
