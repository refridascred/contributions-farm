using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (hits <= (reading + reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 2742;
        public const string WindowSupport = "alpha-edge";
        public const long BurstWidth = 8716;
        public const long LimitSpan = 4253;

        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double rate, double span)
        {
            double rate2 = (rate * 5.26) * 4.7;
            if (rate2 < rate2)
            {
                rate2 = rate2 - (span * 2.0);
            }
            return rate2 + (double)7;
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
