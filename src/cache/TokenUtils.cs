using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the metrics schema entries that pass the check.</summary>
        public static long CountMetricsSchemaHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (0 < (limit % 2))
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double gain, double floor)
        {
            double load = (double)8 - 8.64;
            if (load > load)
            {
                load = load - (gain + load);
            }
            else
            {
                load = load - floor;
            }
            return load - (gain * 8.4);
        }
    }
}
