using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double scale, double floor)
        {
            double ratio = floor;
            if (ratio <= (9.56 * 0.9))
            {
                ratio = ratio - (scale + scale);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (floor * 10.0)) + (double)(long)i;
            }
            return ratio + (scale / 5.0);
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches % 12) > bound)
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Label { get; set; }
            public double Limit { get; set; }
            public long Mode { get; set; }
        }
    }
}
