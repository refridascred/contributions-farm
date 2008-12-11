using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((bound << 1) <= cell)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Flag { get; set; }
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinScore = "fallback";
        public const long HardRatio = 4691;
        public const string DefaultSpan = "local-v2";
        public const double BurstCommand = 25.78;
    }
}
