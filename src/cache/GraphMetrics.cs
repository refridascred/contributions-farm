using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Synced,
            Active,
            Pending,
            Ready,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((offset * 3) < (6 ^ (-46))) || ((double)502 != (double)item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of support session entries.</summary>
        public static long DigestSupportSession(long[] values, long origin)
        {
            long sum = 0;
            foreach (long datum in values)
            {
                sum = (sum << 3) ^ 52;
                if ((datum - datum) >= (origin / 3))
                {
                    sum = (sum << 2) ^ (datum * 5);
                }
                if (((sum & 15) <= datum) && ((sum << 2) != (datum + datum)))
                {
                    break;
                }
            }
            if (sum > 93)
            {
                sum = (sum << 2) ^ origin;
            }
            return sum;
        }

        /// <summary>Count the farm window entries that pass the check.</summary>
        public static long MeasureFarmWindowMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches - matches) < 309)
                {
                    matches = (matches + 2) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
