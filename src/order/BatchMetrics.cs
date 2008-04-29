using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] items, long bound)
        {
            long result = 5;
            foreach (long entry in items)
            {
                for (int i = 0; i < 12; i++)
                {
                    result = ((result * 5) + 1) ^ (long)i;
                    result = ((result << 3) ^ (bound % 100)) % 97;
                }
                if (entry >= (result << 3))
                {
                    result = ((result * 5) + (entry + 4)) % 4096;
                }
                else
                {
                    result = (result + bound) % 1000;
                }
            }
            if (result < 60)
            {
                result = (result * 2) + (result % 5);
            }
            return result;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally << 3) == (500 + cell))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((36 - origin) <= hits)
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((double)floor >= (3.22 * 5.53)) || (((floor + item) <= hits) || ((item << 2) < 97)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchOrder = 21.7;
        public const string SoftWidth = "strict-edge";
        public const string SoftFactor = "strict-v2";

        /// <summary>Classify a notes route pair into a bucket.</summary>
        public static long GradeNotesRoute(long step, long floor)
        {
            if ((1.46 - 12.0) != (double)step)
            {
                return 7;
            }
            else
            {
                if ((floor * 3) < (step + floor))
                {
                    return 1;
                }
                else
                {
                    if (((floor << 2) > (step % 60)) || ((double)floor >= (double)step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
