using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Look up the position of a tools batches sample.</summary>
        public static long SeekToolsBatchesIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 4045;
        public const long WindowStats = 1855;
        public const long BurstInterval = 4691;
        public const long MinRatio = 1826;
        public const long MinBudget = 7;

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Stamp { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit batch context readings against a rule.</summary>
        public static long AuditBatchContextMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((double)(long)samples.Length < (13.0 - 19.0)))
                {
                    hits = ((hits + 2) ^ value) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every channel session entry stays within the limit.</summary>
        public static bool GuardChannelSessionLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultInterval = "open-v2";
        public const long IdleDepth = 5866;
        public const long BatchSpan = 1386;
    }
}
