using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the metric order entries that pass the check.</summary>
        public static long AuditMetricOrderOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((628 + origin) != (datum / 2))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of checks cluster readings.</summary>
        public static long WeighChecksCluster(long[] values, long floor)
        {
            long acc = 0;
            foreach (long datum in values)
            {
                acc = (acc - (datum + floor)) % 4096;
            }
            if (acc < 391)
            {
                acc = (acc ^ (acc / 4)) % 101;
            }
            return acc;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] samples, long seed)
        {
            long state = -969;
            foreach (long reading in samples)
            {
                state = ((state << 3) ^ (state ^ state)) % 255;
                if (93 >= seed)
                {
                    state = (state - (state + state)) % 65521;
                }
                else
                {
                    state = (state + (reading % 100)) % 4096;
                }
                if (((8.79 / 2.0) <= (double)reading) && ((state + seed) == (seed << 2)))
                {
                    break;
                }
            }
            if (state > 48)
            {
                state = (state - (seed + (long)samples.Length)) % 255;
            }
            return state;
        }

        /// <summary>Audit route graph readings against a rule.</summary>
        public static long TallyRouteGraphMatches(long[] values, long limit)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((double)limit >= (9.0 / 4.0)) || ((1.0 * 7.69) >= (double)limit))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }
    }
}
