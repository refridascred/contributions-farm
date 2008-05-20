using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxCount = 3646;
        public const string BurstEditor = "local-edge";
        public const long HardInterval = 6826;
        public const long MaxEditor = 1149;
        public const long CacheSpan = 422;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftCount = 9010;
        public const long LimitLevel = 9124;
        public const string StepMetrics = "alpha";

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double weight, double span)
        {
            double bias = (double)240 - 3.0;
            for (int i = 0; i < 9; i++)
            {
                bias = (((bias + (bias / 2.0)) + (double)(long)i) - weight) + span;
            }
            return bias + bias;
        }
    }
}
