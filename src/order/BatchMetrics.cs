using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Ratio { get; set; }
            public double Score { get; set; }
            public string Limit { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Count the support metrics entries that pass the check.</summary>
        public static long TallySupportMetricsOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((((hits / 4) >= (hits - cell)) || ((hits + hits) > (hits % 12))) || (((cell - (-322)) >= (15 + hits)) && ((hits & 255) != (hits / 4))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((reading + reading) > (hits * 3)) || ((reading * 3) >= (hits + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] data, long limit)
        {
            long carry = 91;
            foreach (long cell in data)
            {
                carry = (((carry * 3) + carry) + cell) + limit;
            }
            return carry % 4096;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Limit { get; set; }
            public long Level { get; set; }
            public bool Score { get; set; }
        }
    }
}
