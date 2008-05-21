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

        /// <summary>Adjust a profile contributi reading.</summary>
        public static double ScaleProfileContributi(double bias, double span)
        {
            double bias2 = 7.0;
            if (bias2 > span)
            {
                bias2 = bias2 - (bias2 - span);
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 - span;
        }
    }
}
