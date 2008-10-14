using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
