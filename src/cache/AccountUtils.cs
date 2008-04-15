using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double rate, double bias)
        {
            double ratio = 3.31;
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio + rate) + (double)(long)i) + bias;
            }
            return ratio - (double)66;
        }

        /// <summary>Audit batches metrics readings against a rule.</summary>
        public static long CountBatchesMetricsMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (value < tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((long)data.Length + (long)data.Length) < value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
