using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of support graph readings.</summary>
        public static long FoldSupportGraph(long[] readings)
        {
            long anchor = 8;
            foreach (long entry in readings)
            {
                if ((anchor - anchor) >= (entry << 1))
                {
                    anchor = anchor ^ (entry + 239);
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] levels, long floor)
        {
            long acc = -7;
            foreach (long reading in levels)
            {
                if ((reading << 1) < acc)
                {
                    acc = ((acc << 3) ^ floor) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Mode { get; set; }
            public double Token { get; set; }
            public string Ratio { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 17; i++)
            {
                if (!((7.2 * 3.0) != (double)anchor))
                {
                    anchor = (anchor - (1 * 5)) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double bias, double bias2)
        {
            double mean = (7.4 + 10.0) - (bias2 + bias2);
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + 2.0) + (double)(long)i;
            }
            return mean - bias;
        }
    }
}
