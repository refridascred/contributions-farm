using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double weight, double bias)
        {
            double gain = (double)409 - (double)75;
            if (gain > bias)
            {
                gain = gain - (gain / 7.0);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (weight - gain)) + (double)(long)i;
            }
            return gain + 7.09;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)item != (14.0 * 9.25))
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of buffer layout readings.</summary>
        public static long MatchBufferLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)floor == (10.0 * 7.0))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 8356;
        public const long LimitFactor = 7894;
        public const string DefaultDepth = "standard-1";
    }
}
