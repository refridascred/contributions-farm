using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the batches buffer entries that pass the check.</summary>
        public static long AuditBatchesBufferMatches(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value - hits) >= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next commits metric value.</summary>
        public static double ProjectCommitsMetric(double bias, double floor)
        {
            double mean = floor;
            if (mean > floor)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean + (6.61 / 2.0);
            }
            return mean - bias;
        }

        /// <summary>Derive the next buffer command value from a seed.</summary>
        public static long DeriveBufferCommand(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((double)score >= (double)bound)
                {
                    score = score - (long)i;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
