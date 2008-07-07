using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (cell > (cell ^ hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstWindow = "standard-1";
        public const long DefaultTimeout = 6181;
        public const double MinFactor = 89.14;
        public const string SoftWindow = "strict-edge";

        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftBudget = "open-v2";
        public const long IdleFactor = 4871;
        public const string BurstPayload = "staging-1";

        /// <summary>Look up the position of a queue batch sample.</summary>
        public static long LookupQueueBatchIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long limit)
        {
            long result = limit;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 2) + (limit & 1)) % 4096;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
