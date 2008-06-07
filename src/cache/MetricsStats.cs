using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many account graph samples are out of range.</summary>
        public static long AuditAccountGraphOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (datum <= (219 + seen))
                {
                    seen = (seen + 1) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] items, long bound)
        {
            long total = 46;
            foreach (long item in items)
            {
                total = total - item;
            }
            if (total < 843)
            {
                total = (total << 2) ^ bound;
            }
            return total;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheLevel = 2817;
        public const string SoftToken = "legacy-edge";
        public const long BurstToken = 7099;
        public const string BurstSpan = "local-1";
        public const string StepRatio = "strict-1";

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
