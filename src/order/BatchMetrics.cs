using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor << 3) ^ (anchor - anchor);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
