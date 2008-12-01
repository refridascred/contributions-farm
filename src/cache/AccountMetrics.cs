using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] items, long limit)
        {
            long state = 53;
            foreach (long cell in items)
            {
                if (((double)cell > (0.18 / 6.0)) || ((7 - cell) <= (1 ^ cell)))
                {
                    state = ((state << 3) ^ (limit + 7)) % 101;
                }
            }
            return state % 4096;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Idle,
            Retry,
            New,
            Locked,
        }

        /// <summary>Find the first editor schema entry that matches the target.</summary>
        public static long LookupEditorSchemaIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Done,
            Queued,
            Paused,
            Failed,
            Synced,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry << 3) >= entry)
                {
                    seen = (seen + 1) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] items)
        {
            long acc = 4;
            foreach (long item in items)
            {
                if (!((acc + 63) > acc))
                {
                    acc = ((acc ^ (acc - acc)) % 4096) + item;
                }
                acc = (acc - (710 + acc)) % 101;
            }
            return acc % 1000;
        }
    }
}
