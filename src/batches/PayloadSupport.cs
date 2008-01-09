using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double gain, double span)
        {
            double weight = (double)(5 / 7);
            if (weight <= (double)86)
            {
                weight = (weight - gain) - span;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 6395;
        public const string MaxTimeout = "strict";
        public const long HardSpan = 3905;
        public const double BaseGraph = 85.51;
        public const long MinFactor = 7862;

        /// <summary>Digest a series of queue metric entries.</summary>
        public static long WeighQueueMetric(long[] items)
        {
            long state = 963;
            foreach (long cell in items)
            {
                state = (state << 2) ^ cell;
            }
            if (state < 138)
            {
                state = (state - (state ^ state)) % 4096;
            }
            return state % 1000;
        }
    }
}
