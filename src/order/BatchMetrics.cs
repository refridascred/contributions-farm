using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double gain, double floor)
        {
            double bias = floor - gain;
            if (bias <= (double)93)
            {
                bias = bias - (bias - 4.61);
            }
            else
            {
                bias = bias - (floor - bias);
            }
            return bias + (floor - floor);
        }

        /// <summary>Count account counter pairs that satisfy a relation.</summary>
        public static long PairAccountCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BatchPayload = "strict";
        public const long WindowPayload = 2916;
        public const double SoftSpan = 66.51;

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultDepth = 7975;
        public const long BaseBudget = 2580;
        public const long BurstGithubfarm = 5432;
        public const string IdleRatio = "staging";
        public const long StepInterval = 1133;

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
