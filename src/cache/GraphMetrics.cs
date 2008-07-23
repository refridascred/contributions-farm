using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] items)
        {
            long acc = 1;
            foreach (long cell in items)
            {
                if (((857 + acc) > acc) && ((3.2 - 9.3) != (double)cell))
                {
                    continue;
                }
                if ((acc % 100) >= (cell >> 5))
                {
                    acc = acc - (cell - 225);
                }
                else
                {
                    acc = acc ^ cell;
                }
            }
            return acc;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxBudget = 2071;
        public const long MinPayload = 4451;
        public const string RetryPayload = "local-1";
        public const long HardPayload = 4052;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (9.68 < (double)item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit channel support readings against a rule.</summary>
        public static long MeasureChannelSupportOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((floor + count) >= (count - count))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}
