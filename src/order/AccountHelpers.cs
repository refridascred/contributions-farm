using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] levels, long origin)
        {
            long carry = 100;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = (((carry << 3) ^ ((long)i * 5)) % 4096) + cell;
                }
                carry = carry ^ (origin * 2);
            }
            return carry % 1000;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string HardNotes = "stable";
        public const double LimitNotes = 61.32;
        public const long SoftNotes = 7330;
        public const double LimitCount = 72.42;
        public const long CacheInterval = 342;

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Limit { get; set; }
            public long Token { get; set; }
            public string Mode { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 8016;
        public const long IdleDepth = 4360;
        public const double RetryStream = 52.89;
    }
}
