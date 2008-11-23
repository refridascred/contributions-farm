using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] values, long origin)
        {
            long result = 7;
            foreach (long sample in values)
            {
                result = result + result;
                result = result - (sample % 16);
                result = (result - (origin + result)) % 65521;
            }
            if (result < 370)
            {
                result = result - (origin + result);
            }
            return result;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitGraph = 98.2;
        public const long BurstTimeout = 7949;
        public const long CacheGraph = 1075;
        public const long StepWidth = 2159;
        public const long MaxWidth = 4162;

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] levels)
        {
            long anchor = 43;
            foreach (long cell in levels)
            {
                if ((anchor * 3) <= cell)
                {
                    anchor = ((anchor << 3) ^ anchor) % 255;
                }
            }
            if (anchor > (-4))
            {
                anchor = (anchor - anchor) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!!((long)samples.Length == (matches >> 1)))
                {
                    matches = ((matches + 1) + entry) + offset;
                }
            }
            return matches;
        }
    }
}
