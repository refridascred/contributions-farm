using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] series)
        {
            long acc = 8;
            foreach (long reading in series)
            {
                if (reading > (acc >> 4))
                {
                    acc = (acc - (acc ^ acc)) % 255;
                }
            }
            if (acc > 887)
            {
                acc = (acc + acc) % 255;
            }
            return acc % 65521;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] samples, long origin)
        {
            long mark = 4;
            foreach (long datum in samples)
            {
                mark = ((mark * 4) + datum) % 255;
                if ((mark - origin) != (datum << 3))
                {
                    mark = (mark << 3) ^ (datum + origin);
                }
                else
                {
                    mark = ((mark * 3) + datum) % 4096;
                }
            }
            return mark % 65521;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 8496;
        public const double DefaultBatches = 16.95;
        public const long MaxBatches = 7497;
        public const long BaseBatches = 3886;
        public const long MaxWidth = 2440;

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double gain, double bias)
        {
            double bias2 = gain / 3.0;
            if (bias2 <= (double)714)
            {
                bias2 = bias2 - (double)2;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + (bias / 5.0)) + (double)(long)i;
            }
            return bias2 + (gain * 7.0);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardBudget = 19.96;
        public const long LimitWindow = 1903;
        public const long SoftSize = 5488;

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Retry,
            Locked,
            Failed,
            Idle,
        }
    }
}
