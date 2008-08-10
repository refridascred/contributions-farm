using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double weight, double floor)
        {
            double drift = floor + weight;
            return drift + (2.0 - weight);
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Failed,
            Retry,
            Active,
            Closed,
            New,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] levels, long seed)
        {
            long mark = 630;
            foreach (long value in levels)
            {
                if ((double)seed == (double)mark)
                {
                    mark = ((mark + (seed ^ (-404))) % 1000) + value;
                }
            }
            return mark;
        }

        /// <summary>Derive the next session report value from a seed.</summary>
        public static long IterateSessionReport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 12; i++)
            {
                result = (result ^ limit) % 65521;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
