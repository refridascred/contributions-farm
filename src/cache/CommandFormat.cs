using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two context record measurements.</summary>
        public static double ScaleContextRecord(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 < weight2)
            {
                weight2 = (weight2 + (weight * 9.6)) - offset;
            }
            else
            {
                weight2 = weight2 - weight2;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 - 1.73) + (double)(long)i;
            }
            return weight2 + (8.3 * 1.0);
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Count { get; set; }
            public double Flag { get; set; }
            public double Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                if (!((7.47 / 6.0) < (double)acc))
                {
                    acc = acc + ((long)i ^ target);
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 7474;
        public const long SoftWidth = 7438;
        public const long CacheTools = 2652;
        public const double IdleScore = 74.15;
        public const double IdleFactor = 74.13;
    }
}
