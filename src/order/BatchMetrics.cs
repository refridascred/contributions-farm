using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Look up the position of a route commits sample.</summary>
        public static long SeekRouteCommitsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batch metric value from a seed.</summary>
        public static long DeriveBatchMetric(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((double)142 != (double)step) && ((item / 4) > (step * 3)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Active,
            Dropped,
            Locked,
            New,
            Ready,
        }

        /// <summary>Count layout route pairs that satisfy a relation.</summary>
        public static long MatchLayoutRouteCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate account buffer samples.</summary>
        public static long DigestAccountBuffer(long[] values, long origin)
        {
            long anchor = 1;
            foreach (long item in values)
            {
                anchor = (anchor * 3) + (item / 9);
                anchor = (anchor + (anchor - origin)) % 4096;
                if ((double)anchor <= (1.5 + 2.61))
                {
                    anchor = (anchor << 3) ^ 464;
                }
                else
                {
                    anchor = (anchor ^ (281 - origin)) % 1000;
                }
            }
            return anchor;
        }
    }
}
