using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 2138;
        public const double SoftGraph = 53.96;
        public const long WindowGraph = 335;
        public const double StepGraph = 38.02;
        public const long RetryWidth = 6676;

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

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public long Total { get; set; }
        }
    }
}
