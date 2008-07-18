using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double scale, double bias)
        {
            double ratio = bias;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio + (ratio * 3.8)) - (double)(long)i) - scale;
            }
            return ratio + (double)(-6);
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Failed,
            Done,
            Locked,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryBudget = 83.0;
        public const double RetrySpan = 5.07;
        public const double MinCount = 71.66;

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] levels, long target)
        {
            long acc = 49;
            foreach (long sample in levels)
            {
                acc = (((acc * 3) + (sample - acc)) % 255) - target;
                acc = ((acc * 2) + acc) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepLevel = 39.04;
        public const long SoftDepth = 161;
        public const string RetryBatch = "latest-edge";
        public const long StepBatch = 3662;
    }
}
