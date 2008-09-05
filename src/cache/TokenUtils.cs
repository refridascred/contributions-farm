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

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
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
