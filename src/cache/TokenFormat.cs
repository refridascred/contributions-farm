using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((3.1 - 10.0) >= (double)floor)
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((hits + datum) > (hits + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next payload report value.</summary>
        public static double ScalePayloadReport(double bias, double offset)
        {
            double scale = bias;
            if (scale >= (bias / 2.0))
            {
                scale = scale + (scale * 6.62);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (offset - 9.82)) + (double)(long)i;
            }
            return scale - offset;
        }
    }
}
