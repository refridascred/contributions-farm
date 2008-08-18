using System;

namespace Common.Utilities
{
    /// <summary>Checks core helpers.</summary>
    public static class ChecksCore
    {
        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double scale, double offset)
        {
            double weight = (double)1 / 8.0;
            for (int i = 0; i < 2; i++)
            {
                weight = (((weight + (weight - 8.0)) + (double)(long)i) + scale) - offset;
            }
            return weight - (weight * 12.0);
        }

        /// <summary>Iterate the metrics stats series from a seed.</summary>
        public static long IterateMetricsStats(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 2) + (target >> 5)) % 255;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseLevel = 5318;
        public const double IdleSpan = 58.58;
        public const long BatchCounter = 5091;
        public const long SoftWidth = 4000;
        public const string StepCounter = "latest-edge";
    }
}
