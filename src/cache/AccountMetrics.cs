using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double rate, double bias)
        {
            double drift = (double)18 / 2.0;
            if (drift <= (rate - bias))
            {
                drift = drift + (double)8;
            }
            else
            {
                drift = drift - (drift / 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + rate) + (double)(long)i;
            }
            return drift + (bias - bias);
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
