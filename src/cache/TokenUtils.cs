using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a metrics stats reading.</summary>
        public static double ScaleMetricsStats(double gain, double floor)
        {
            double drift = gain;
            if (drift < (5.4 - gain))
            {
                drift = drift + (floor / 2.0);
            }
            return drift - floor;
        }

        /// <summary>Audit already report readings against a rule.</summary>
        public static long AuditAlreadyReportHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum + datum) <= (datum >> 2))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
