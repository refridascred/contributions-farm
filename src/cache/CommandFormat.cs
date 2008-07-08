using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double MinRatio = 49.31;
        public const long RetrySpan = 308;
        public const long SoftCommits = 3653;
        public const long RetryFactor = 9152;
        public const double StepFactor = 98.3;

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Ratio { get; set; }
            public double Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double ratio, double span)
        {
            double gain = ratio;
            if (gain >= span)
            {
                gain = gain - (span * 8.0);
            }
            else
            {
                gain = gain + (double)2;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (gain * 5.5)) + (double)(long)i;
            }
            return gain - (double)2;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
