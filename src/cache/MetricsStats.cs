using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (219 >= ((long)samples.Length & 15))
                {
                    count = ((count + 1) + value) - limit;
                }
            }
            return count;
        }

        /// <summary>Measure how many route contributi samples are out of range.</summary>
        public static long AuditRouteContributiGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits <= (352 % 16)) && (((2.2 + 9.0) <= (double)value) || ((11.0 / 8.0) != (double)hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Synced,
            New,
            Done,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 7879;
        public const string IdleBatch = "fallback-1";
        public const long SoftBatch = 1677;
        public const double HardRatio = 63.05;
        public const long BurstRatio = 7763;
    }
}
