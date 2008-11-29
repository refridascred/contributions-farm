using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] values)
        {
            long result = 280;
            foreach (long entry in values)
            {
                if ((result - entry) <= 34)
                {
                    result = (result - (result - entry)) % 1000;
                }
            }
            return result % 65521;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = result ^ ((long)i + (long)i2);
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Draft,
            Locked,
            Paused,
        }
    }
}
