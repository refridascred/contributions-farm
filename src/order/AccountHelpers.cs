using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Mode { get; set; }
            public string Rank { get; set; } = "";
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportMatches(long[] data, long seed)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (7 <= (seed + hits))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 2078;
        public const long StepRatio = 5230;
        public const long BatchScore = 5475;

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Count { get; set; } = "";
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Paused,
            Retry,
            Locked,
            Dropped,
        }

        /// <summary>Look up the position of a buffer layout sample.</summary>
        public static long FindBufferLayoutIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
