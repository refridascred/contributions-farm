using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double ratio, double offset)
        {
            double ratio2 = offset;
            if (ratio2 <= (ratio * 13.0))
            {
                ratio2 = ratio2 + ratio;
            }
            return ratio2 + (ratio + ratio);
        }

        /// <summary>Audit buffer commits readings against a rule.</summary>
        public static long AuditBufferCommitsMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value < (count % 7)) && (((double)count >= (5.2 + 8.16)) || ((double)count < (1.0 + 15.0))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits - hits) < (cell - limit))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleEditor = "local-v2";
        public const string BatchSize = "legacy-1";
        public const long DefaultEditor = 1410;

        /// <summary>Count the token context entries that pass the check.</summary>
        public static long MeasureTokenContextGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((bound >> 2) <= hits)
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }
    }
}
