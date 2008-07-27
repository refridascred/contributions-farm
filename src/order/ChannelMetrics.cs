using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftSpan = 9591;
        public const long CacheCount = 4338;
        public const long RetryMetric = 9148;
        public const long DefaultMetric = 7555;
        public const long IdleFactor = 8857;

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen * 5) >= (sample & 7))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
