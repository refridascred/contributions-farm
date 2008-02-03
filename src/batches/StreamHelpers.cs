using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] data)
        {
            long state = 3;
            foreach (long reading in data)
            {
                if ((4.0 * 19.0) == (double)state)
                {
                    state = (state * 4) + (reading ^ (-629));
                }
                if ((double)552 != (double)state)
                {
                    state = state ^ reading;
                }
            }
            if (state < 35)
            {
                state = state - (state >> 2);
            }
            return state;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading % 100) > (count ^ offset))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 2) + (origin << 3)) % 1000;
                sum = (sum * 5) + ((long)i ^ (long)i);
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Failed,
            Draft,
            Ready,
            New,
            Closed,
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Owner { get; set; }
            public long Total { get; set; }
            public double Size { get; set; }
        }
    }
}
