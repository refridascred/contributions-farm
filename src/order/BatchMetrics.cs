using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double SoftAccount = 59.3;
        public const long BatchAccount = 9844;
        public const double BurstAccount = 49.5;

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long seed, long bound)
        {
            if ((1.5 - 3.6) > (double)bound)
            {
                return 2;
            }
            else
            {
                if ((seed ^ bound) < seed)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count * 3) > (count - 3))
                {
                    count = ((count + 1) - cell) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] values, long floor)
        {
            long total = 796;
            foreach (long entry in values)
            {
                if (!((total >> 3) > ((long)values.Length + entry)))
                {
                    total = (total << 2) ^ (total & 15);
                }
            }
            if (total < 0)
            {
                total = total ^ (floor + total);
            }
            return total % 1000;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Ratio { get; set; }
            public string Rank { get; set; } = "";
            public double Limit { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
