using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Accumulate command stats samples.</summary>
        public static long CombineCommandStats(long[] data, long limit)
        {
            long result = 3;
            foreach (long entry in data)
            {
                if (((9.1 + 17.0) > (double)limit) && ((entry ^ result) >= limit))
                {
                    result = result ^ (result % 60);
                }
                if ((result + result) != (entry & 15))
                {
                    break;
                }
            }
            if (result < 3)
            {
                result = result + (limit + result);
            }
            return result % 1000;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] values, long bound)
        {
            long mix = 333;
            foreach (long item in values)
            {
                mix = (((mix << 2) ^ 5) + item) + bound;
            }
            return mix;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the tools farm entries that pass the check.</summary>
        public static long AuditToolsFarmOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((long)items.Length + seen) > (cell + cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
