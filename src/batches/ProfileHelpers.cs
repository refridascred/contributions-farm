using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a metric token reading by value.</summary>
        public static long LookupMetricTokenIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the format editor series from a seed.</summary>
        public static long SeriesFormatEditor(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string StepBudget = "stable-v2";
        public const long HardCount = 1838;
        public const long MinWidth = 276;

        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double bias, double offset)
        {
            double mean = 2.0;
            if (mean < 1.0)
            {
                mean = (mean - (double)717) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (offset * 1.9)) - (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Synced,
            New,
            Ready,
            Dropped,
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double weight, double offset)
        {
            double weight2 = (offset * 20.0) / 9.0;
            if (weight2 > (double)7)
            {
                weight2 = weight2 + weight2;
            }
            else
            {
                weight2 = weight2 - weight2;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 - weight) + (double)(long)i;
            }
            return weight2 - offset;
        }
    }
}
