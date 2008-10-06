using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] levels)
        {
            long mark = 2;
            foreach (long cell in levels)
            {
                mark = ((mark * 5) + (cell * 2)) % 101;
            }
            if (mark > 729)
            {
                mark = mark + (mark << 3);
            }
            return mark % 65521;
        }

        /// <summary>Audit metric metrics readings against a rule.</summary>
        public static long CountMetricMetricsHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((6.3 / 8.0) <= (double)cell)
                {
                    matches = (matches + 1) + limit;
                }
            }
            return matches;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] samples)
        {
            long sum = 735;
            foreach (long entry in samples)
            {
                if ((entry - 8) >= (entry + entry))
                {
                    sum = ((sum << 3) ^ (383 + 25)) % 97;
                }
            }
            return sum;
        }
    }
}
