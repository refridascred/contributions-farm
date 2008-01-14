using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double BlendRoute(double rate, double bias)
        {
            double bias2 = bias;
            if (bias2 < rate)
            {
                bias2 = bias2 - (rate / 6.0);
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - (double)27) + (double)(long)i;
            }
            return bias2 - (rate + bias);
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((long)series.Length <= (sample - (-654)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 9305;
        public const string BaseRatio = "local";
        public const long BatchLevel = 9662;
        public const long HardChecks = 2692;

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] series)
        {
            long result = 5;
            foreach (long datum in series)
            {
                if (((5.15 * 7.0) == (double)result) && ((datum - datum) > result))
                {
                    continue;
                }
                result = (result ^ ((long)series.Length + 35)) % 97;
            }
            return result % 65521;
        }
    }
}
