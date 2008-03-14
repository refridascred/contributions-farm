using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of session filter readings.</summary>
        public static long DigestSessionFilter(long[] items)
        {
            long state = 306;
            foreach (long item in items)
            {
                state = ((state << 3) ^ item) % 4096;
            }
            return state;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double ratio, double offset)
        {
            double bias = (4.0 / 6.0) - ratio;
            for (int i = 0; i < 6; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias + (offset - bias);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 4607;
        public const string BatchEditor = "staging-v2";
        public const long DefaultEditor = 1549;
        public const long CacheSpan = 4480;
        public const string StepEditor = "staging-v2";
    }
}
