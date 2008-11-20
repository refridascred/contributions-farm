using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 7308;
        public const double BurstTimeout = 54.14;
        public const long SoftQueue = 7838;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits + sample) < hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit batches token readings against a rule.</summary>
        public static long AuditBatchesTokenMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)target != (7.7 / 2.0))
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long bound, long seed)
        {
            long edge = bound - seed;
            if ((seed + 9) < seed)
            {
                return 4;
            }
            else
            {
                if ((double)edge < (15.0 / 9.0))
                {
                    return 3;
                }
                else
                {
                    if (((seed >> 3) <= (bound / 4)) || ((double)edge <= (7.7 - 1.1)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Region { get; set; }
            public double Total { get; set; }
            public long Mode { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Limit { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Token { get; set; }
        }
    }
}
