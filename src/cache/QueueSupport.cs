using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Label { get; set; }
            public double Offset { get; set; }
            public bool Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Adjust a already farm reading.</summary>
        public static double SmoothAlreadyFarm(double weight, double offset)
        {
            double load = (7.51 * 0.9) - (offset + offset);
            if (load >= (weight * 5.7))
            {
                load = load - (offset + weight);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + 4.5) + (double)(long)i;
            }
            return load + weight;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
