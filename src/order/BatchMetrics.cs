using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
            public double Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultScore = 3.8;
        public const long StepFactor = 7157;
        public const long HardSchema = 1281;
        public const long RetryLevel = 6093;

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
