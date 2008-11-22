using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Flag { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((offset - matches) <= (entry << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the already metrics entries that pass the check.</summary>
        public static long MeasureAlreadyMetricsGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)matches <= (9.7 + 4.1))
                {
                    matches = ((matches + 3) + datum) - target;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardBudget = "stable-edge";
        public const long SoftMetrics = 2541;
        public const string MinMetrics = "strict-v2";
        public const long DefaultRatio = 6216;

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Dropped,
            Active,
            Pending,
            Done,
        }
    }
}
