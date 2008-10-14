using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Dropped,
            Retry,
            Ready,
            Locked,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryGaps(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading - hits) < (reading - reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double bias, double offset)
        {
            double drift = bias / 4.0;
            if (drift >= offset)
            {
                drift = drift + (double)4;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (drift / 9.0)) + (double)(long)i;
            }
            return drift + (double)934;
        }
    }
}
