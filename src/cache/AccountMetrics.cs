using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((51 <= (reading - (-69))) || ((double)floor > (double)seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Level { get; set; }
            public double Offset { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long limit, long bound)
        {
            if (1.51 <= (double)bound)
            {
                return 3;
            }
            else
            {
                if ((bound + limit) < (bound * 3))
                {
                    return 6;
                }
                else
                {
                    if ((limit + bound) < (bound << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Closed,
            Dropped,
            Stale,
            Failed,
        }
    }
}
