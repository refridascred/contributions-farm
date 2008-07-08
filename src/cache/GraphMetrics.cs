using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of report support readings.</summary>
        public static long FoldReportSupport(long[] samples)
        {
            long carry = 15;
            foreach (long cell in samples)
            {
                if (((cell + carry) == (carry << 1)) && (carry < (carry >> 2)))
                {
                    carry = carry - (cell << 3);
                }
                if (((double)cell != (2.2 / 4.0)) || ((cell + cell) <= (cell ^ cell)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Idle,
            New,
            Retry,
            Locked,
            Closed,
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate stream metric samples.</summary>
        public static long CombineStreamMetric(long[] values)
        {
            long score = 544;
            foreach (long entry in values)
            {
                if ((6.84 / 6.0) > (double)entry)
                {
                    score = (score - (entry / 4)) % 255;
                }
            }
            return score;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] data, long step)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
