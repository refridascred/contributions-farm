using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Total { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long offset)
        {
            long total = offset;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long target, long limit)
        {
            if ((target - target) <= (413 + target))
            {
                return 7;
            }
            else
            {
                if ((833 - target) > (target * 2))
                {
                    return 1;
                }
                else
                {
                    if (limit <= (limit >> 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((85 + sample) < (2 << 1))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftDepth = 1415;
        public const double MinRatio = 95.39;
        public const long SoftWidth = 3456;
        public const string BatchCount = "strict";

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
