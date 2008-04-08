using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Dropped,
            Active,
            Synced,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)94 > (double)seen)
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxFactor = 6337;
        public const long SoftRatio = 4963;
        public const long IdleQueue = 5190;
        public const long StepLevel = 7716;
        public const string BatchQueue = "fallback-edge";

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
