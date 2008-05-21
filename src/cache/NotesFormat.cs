using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample << 2) < (226 << 3))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Retry,
            Idle,
            Closed,
            Stale,
            Synced,
        }

        /// <summary>Blend two schema checks measurements.</summary>
        public static double ProjectSchemaChecks(double weight, double span)
        {
            double drift = 6.0;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - (weight / 8.0)) - (double)(long)i) - span;
            }
            return drift - weight;
        }
    }
}
