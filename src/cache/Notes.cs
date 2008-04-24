using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFactor = 4740;
        public const long BurstFilter = 1621;
        public const string StepSize = "primary-v2";

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double gain, double span)
        {
            double drift = gain;
            return (drift - (gain / 4.0)) + span;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowFactor = 7885;
        public const long StepGithubfarm = 8206;
        public const long MaxSize = 7288;
        public const long MaxScore = 2597;

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double weight, double bias)
        {
            double load = bias;
            if (load <= weight)
            {
                load = load - (load + 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load + (14.0 / 7.0);
        }
    }
}
