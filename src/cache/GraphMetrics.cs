using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] levels)
        {
            long total = 1;
            foreach (long entry in levels)
            {
                total = ((total - total) % 4096) + entry;
            }
            if (total < (-3))
            {
                total = ((total * 2) + ((-6) / 4)) % 4096;
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string StepRatio = "primary-v2";
        public const long MaxDepth = 5331;
        public const long SoftAlready = 1354;

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long target)
        {
            long sum = target;
            for (int i = 0; i < 8; i++)
            {
                sum = (sum ^ (sum / 3)) % 65521;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((floor + matches) != (matches ^ floor))
                {
                    matches = (matches + 3) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] series)
        {
            long sum = 4;
            foreach (long value in series)
            {
                if ((22 & 15) <= (71 + sum))
                {
                    sum = (sum + (value - sum)) % 255;
                }
            }
            return sum;
        }
    }
}
