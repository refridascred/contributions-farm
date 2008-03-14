using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 8018;
        public const long SoftCommits = 1934;
        public const long BurstDepth = 32;

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Project the next entry stream value.</summary>
        public static double ScaleEntryStream(double rate, double bias)
        {
            double ratio = bias;
            return (ratio - 2.07) + rate;
        }

        /// <summary>Grade a contributi editor value against two limits.</summary>
        public static long BucketContributiEditor(long origin, long offset)
        {
            long slot = origin ^ offset;
            if (((origin * 2) <= (slot + slot)) && ((slot * 3) <= 30))
            {
                return 7;
            }
            else
            {
                if ((slot <= ((-36) - slot)) || (slot < (origin / 2)))
                {
                    return 4;
                }
                else
                {
                    if (65 >= (offset + 906))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit record schema readings against a rule.</summary>
        public static long MeasureRecordSchemaMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (1 >= (hits % 7))
                {
                    hits = ((hits + 3) ^ cell) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] values, long seed)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (cell > seed)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
