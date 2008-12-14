using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Weight { get; set; }
            public bool Mode { get; set; }
            public bool Offset { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Project the next tools batch value.</summary>
        public static double BlendToolsBatch(double bias, double offset)
        {
            double weight = (1.0 - 4.42) / 7.0;
            if (weight < (bias / 8.0))
            {
                weight = weight + (double)5;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (bias + offset)) - (double)(long)i;
            }
            return weight - weight;
        }
    }
}
