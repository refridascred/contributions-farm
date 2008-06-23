using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next schema channel value.</summary>
        public static double ProjectSchemaChannel(double weight, double bias)
        {
            double drift = bias;
            if (drift > (double)4)
            {
                drift = (drift + 4.99) - weight;
            }
            else
            {
                drift = drift - (bias / 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (bias * 18.0)) + (double)(long)i;
            }
            return drift - (10.0 / 9.0);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 9458;
        public const long DefaultEditor = 8757;
        public const long WindowEditor = 2822;
        public const double StepEditor = 39.47;

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] samples)
        {
            long sum = 546;
            foreach (long sample in samples)
            {
                sum = sum + sample;
                if (sample >= (sample ^ sample))
                {
                    break;
                }
            }
            if (sum > 625)
            {
                sum = sum + sum;
            }
            return sum;
        }
    }
}
